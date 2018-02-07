using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.AddRating(5);
            //diary.AddRating(8.5f);
            //diary.AddRating(4.7f);

            //float avg = diary.CallculateAverge();
            //float max = diary.GiveMaxRatings();
            //float min = diary.GiveMinRating();

            for (; ; )
            {
                Console.WriteLine("Podaj ocenę z zakresu 1-10. Gdy wpiszesz wszystkie oceny wpisz 11. ");
                float rating; 
                   bool results = float.TryParse((Console.ReadLine()), out rating);
                

                if (rating == 11)
                {
                    break;
                }
                if (results == true)
                {
                    if (rating >0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Podałeś niewłaściwą liczbę ");
                        
                    }
                }
                
            }
            Console.WriteLine("Oto średnia twoich ocen: " + diary.CallculateAverge());
            Console.WriteLine("Twoja najwyższa ocena to: " + diary.GiveMaxRatings());
            Console.WriteLine("Oto twoja najniższa ocena: " + diary.GiveMinRating());
            Console.ReadKey();
        }
    }
}
