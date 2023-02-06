using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int picturesCount = 52;
            int numberPerRows = 3;
            int filledRows = picturesCount / numberPerRows;
            int surplusPictures = picturesCount % numberPerRows;
            Console.WriteLine($"Полностью заполненных рядов - {filledRows}. Избыток картинок - {surplusPictures}");
        }
    }
}
