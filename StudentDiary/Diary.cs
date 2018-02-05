using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentDiary
{
    class Diary
    {
        //Stan (zmienne - pola)
        List<float> ratings;
        //Zachowania
        public void Rating(float rating)
        {
            ratings.Add(rating);
        }
        public float CallculateAverge()
        {
            float sum = 0, avg = 0;

            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();
            return avg;
        }
        public float GiveMaxRatings()
        {
            return ratings.Max();
        }
        public float GiveMinRating()
        {
            return ratings.Min();
        }
    }
}
