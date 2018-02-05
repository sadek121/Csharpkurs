
using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();
            for (; ;)
            {
                Greeting();
                Age();
                Settings();

            }


        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("maxInt =" + maxInt);
            Console.WriteLine("minInt =" + minInt);
            Console.WriteLine("maxLong =" + maxLong);
            Console.WriteLine("minlong =" + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            System.Console.ReadKey();
            System.Console.Clear();
            System.Console.ResetColor();
        }
        /// <summary>
        /// Wypisujemy wiek użytkownika
        /// </summary>
        private static void Age()
        {
            System.Console.Write("Wpisz ile masz lat: ");

            int age;
            bool result = int.TryParse(System.Console.ReadLine(), out age);

            if (age > 18)
            {
                System.Console.ForegroundColor = System.ConsoleColor.Cyan;
                System.Console.WriteLine(" Brawo. Masz ponad 18 lat możesz wypić browara!");
            }

            else if (result == false)
            {
                System.Console.WriteLine("Wpisałeś zły wiek");
            }
            else
            {
                System.Console.ForegroundColor = System.ConsoleColor.DarkMagenta;
                System.Console.WriteLine(" Masz wypij Mleko");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            System.Console.Write("Wpisz swoje imię: ");
            string name = System.Console.ReadLine();

            System.Console.WriteLine("Witaj " + name);
            
        }
    }
}
