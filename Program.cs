using System;
using System.ComponentModel.Design;
using System.Threading.Channels;

namespace Ежедневник
{
    internal class Program
    {

        static DateTime Date = new DateTime(2023, 10, 16);
        static void Main(string[] args)
        {
            Vybor();
        }
        static void Vremya(ConsoleKeyInfo key)
        {
            if (key.Key == ConsoleKey.LeftArrow)
            {
                Date = Date.AddDays(-1);
                Console.Clear();
                Console.WriteLine(Date);
             
            }
            if (key.Key == ConsoleKey.RightArrow)
            {
                Date = Date.AddDays(1);
                Console.Clear();
                Console.WriteLine(Date);
                
            }
            if (Date == new DateTime(2023, 10, 18))
            {
                Console.Clear();
                Menu2();
            }
            if (Date == new DateTime(2023, 10, 19))
            {
                Console.Clear();
                Menu3();
            }
             if (Date == new DateTime(2023, 10, 17))
            {
                Console.Clear();

                Menu1();
            }

        }
        static void Vybor()
        {

            int position = 1;
            Menu();
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                Vremya(key);
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
               
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");

                key = Console.ReadKey();
            }

            if (position == 1 && Date.Date == new DateTime(2023, 10, 17))
            {
                Description11();
            }
            if (position == 2 && Date.Date == new DateTime(2023, 10, 17)) 
            {
                Description12();
            }
            if (position == 1 && Date.Date == new DateTime(2023, 10, 18))
            {
                Description21();
            }
            if (position == 1 && Date.Date == new DateTime(2023, 10, 19))
            {
                Description31();
            }
            if (position == 2 && Date.Date == new DateTime(2023, 10, 19))
            {
                Description32();
            }
            if (position == 3 && Date.Date == new DateTime(2023, 10, 19))
            {
                Description33();
            }

        }
        static void Menu()
        {
            Console.WriteLine(Date);
          
        }


        static void Menu1()
        {
            Console.WriteLine(Date);
            Console.WriteLine("  1. Купить ватные диски");
            Console.WriteLine("  2. Забрать посылку");
        }
        static void Menu2()

        {
            Console.WriteLine(Date);
            Console.WriteLine("  1. Продать ватные диски");
        }
        static void Menu3()
        {
            Console.WriteLine(Date);
            Console.WriteLine("  1. Покорми кота");
            Console.WriteLine("  2. Полей кота");
            Console.WriteLine("  3. Помой цветы");

        }


        static void Description11()
        {
            Console.Clear();
            Console.WriteLine("Описание: мама попросила");
            Console.WriteLine("Дата:" + Date);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Vybor();
        }
        static void Description12()
        {
            Console.Clear();
            Console.WriteLine("Описание: пришел набор наклеек, забрать до завтра");
            Console.WriteLine("Дата:" + Date);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Vybor();
        }
        static void Description21()
        {
            Console.Clear();
            Console.WriteLine("Описание: стипендия не скоро ");
            Console.WriteLine("Дата:" + Date);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Vybor();
        }
        static void Description31()
        {
            Console.Clear();
            Console.WriteLine("Описание: он умрет так с голоду ");
            Console.WriteLine("Дата:" + Date);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Vybor();
        }
        static void Description32()
        {
            Console.Clear();
            Console.WriteLine("Описание: оябзательно, а то он засохнет ");
            Console.WriteLine("Дата:" + Date);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Vybor();
        }
        static void Description33()
        {
            Console.Clear();
            Console.WriteLine("Описание: они воняют");
            Console.WriteLine("Дата:" + Date);
            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();
            Vybor();
        }

    }
}