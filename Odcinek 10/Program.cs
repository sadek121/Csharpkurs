using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            diary.AddRating(4);
            diary.AddRating(2);

            Diary diary2 = diary;
            diary2.AddRating(3);

            Diary diary3 = diary;
            diary3.AddRating(4);
            diary3.AddRating(6);
        }
    }
}
