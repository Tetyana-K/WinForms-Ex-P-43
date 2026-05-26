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
            { "Kyiv", "Kyiv.jpg" },
            {"Lviv", "Lviv.jpg" },
            { "Chernivtsi", "Chernivtsi.jpg" }
        };

        public static int Count => citiesPictures.Count;

        public static string? GetPictureByKey(string key)
        {
            if (citiesPictures.TryGetValue(key, out var image))
                return image;
            return null;


        }
        public static string? GetPIctureByIndex(int index)
        {
            if (index >= 0 && index < citiesPictures.Count)
                return citiesPictures.Values.ElementAt(index);
            return null;
        }
    }
}
