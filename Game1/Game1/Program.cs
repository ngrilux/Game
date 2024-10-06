using System;

namespace Game1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            bool doorOpen = false;
            bool boxOpen = false;
            bool keyObtained = false;
            bool statueActivated = false;
            int Try = 0;
            int art1 = 0;
            int art2 = 0;
            int art3 = 0;
            int arts;
            // Имя
            Console.Write("Введите Ваше имя: ");
            string Name = Console.ReadLine();

            // Возможные действия
            Console.WriteLine("Ты проснулся в неизвестной комнате. Твои действия:");
            Console.WriteLine("1. Открыть дверь");
            Console.WriteLine("2. Посмотреть под кроватью");
            Console.WriteLine("3. Открыть ящик в углу комнаты");
            Console.WriteLine("4. Открыть вентиляцию");
            Console.WriteLine("5. Взглянуть на тумбочку");
            Console.WriteLine("6. Взглянуть на статую возле двери");

            while (true)
            {
                // Выберете действие
                Console.Write("Выбери действие: ");
                int action = int.Parse(Console.ReadLine());

                switch (action)
                {
                    case 1:
                        // Открыть дверь
                        if (boxOpen & keyObtained)
                        {
                            doorOpen = true;
                            Console.WriteLine("Дверь открыта, беги!");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Тебе нужна отмычка для двери");
                        }
                        break;
                   
                    case 2:
                        // Посмотреть под кроватью
                        if (art1 != 1)
                        {

                            Console.WriteLine($"{Name}" + ", ты нашел артефакт под кроватью");
                            art1 = 1;
                        }
                        else if (art1==1)
                        {
                            Console.WriteLine($"{Name}" + ", Вы уже находили здесь артефакт");
                        }
                        break;
                   
                    case 3:
                        // Ящик в углу комнаты
                        if (!boxOpen  & !statueActivated)
                            {
                       
                            Console.WriteLine($"{Name} " + ", ящик закрыт, активируй статую");
                            
                            }
                        else if(!boxOpen & statueActivated)
                        {
                            boxOpen = true;
                            Console.WriteLine("Поздравляем,"+ $"{Name} " + ", Вы открыли тумбочку");
                            keyObtained=true;
                            Console.WriteLine($"{Name} "+", Вы нашли отмычку");
                        }
                        else
                            Console.WriteLine("Ящик уже открыт, Ыы уже взяли отмычку");
                        break;

                   
                    case 4:
                        // Вентиляция
                        if (Try < 2)
                        {
                            Console.WriteLine("Вентиляция закрыта,"+ $"{Name} " + ", попробуйте еще раз");
                            Try++;
                            break;
                        }
                        if (Try == 2)
                        {
                            Try++;
                            Console.WriteLine($"{Name} " + ", Вы нашли артефакт в вентиляции!");
                            art2=1;
                        }
                        else if (art2==1)
                        {
                        Console.WriteLine($"{Name} " + ", Вы уже находили здесь артефакт");
                        }
                        break;
                    
                    case 5:
                        // Осмотреть тумбочку
                        if (art3 != 1)
                        {
                            Console.WriteLine($"{Name} " + ", Вы нашли артефакт на тумбочке");
                            art3 = 1;
                        }
                        else if (art3==1)
                        {
                            Console.WriteLine($"{Name} " + ", Вы уже находили здесь артефакт");
                        }
                        break;
                    case 6:
                        // Посмотреть на статую
                        arts = art1 + art2 + art3;
                        if ((statueActivated==false) & (arts!=3))
                        {
                            Console.WriteLine("Здесь ничего нет");
                            
                        }
                        else if ((statueActivated==false) & (arts == 3))
                        {
                            Console.WriteLine("Ура," +$"{Name} " + ", статуя активирована");
                            statueActivated = true;
                        }
                        else
                        {
                            Console.WriteLine("Статуя уже активирована.");
                        }
                        break;
                    default:
                        Console.WriteLine("Нет такого действия");
                        break;
               
                }

                // Открыта ли дверь
                if (doorOpen)
                {
                    Console.WriteLine("Поздравляем," +$"{Name} " + " Вы выбрались из комнаты!");
                    break;
                }
            }
        }
    }
}

