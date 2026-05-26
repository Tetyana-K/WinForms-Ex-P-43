using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer_demo
{
    public static class CitiesPictures
    {
        static SortedList<string, string> citiesPictures = new SortedList<string, string>()
        {
            { "Kyiv", "Kyiv.jpg" }, // index = 1
            { "Lviv", "Lviv.jpg" }, // index = 2
            { "Chernivtsi", "Chernivtsi.jpg" } // index = 0
        };

        public static int Count => citiesPictures.Count;

        public static string? GetPictureByKey(string key)
        {
            if (citiesPictures.TryGetValue(key, out var image)) // спробуємо отримати значення (назву зображення) за ключем (назвою міста), якщо ключ існує в SortedList
                return image;
            return null;
        }
        public static string? GetPIctureByIndex(int index)
        {
            if (index >= 0 && index < citiesPictures.Count)
                return citiesPictures.Values.ElementAt(index); // отримуємо значення (назву зображення) за індексом, використовуючи ElementAt для доступу до значень SortedList
            return null;
        }
    }
}
