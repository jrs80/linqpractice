using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var gamesList = new List<string>
            {
                "Super Mario Bros.",
                "Donkey Kong",
                "Space Invaders",
                "Centipede",
                "Street Fighter",
                "Tron"
            };

            Console.WriteLine("Original List:");
            foreach(var v in gamesList) Console.WriteLine("\t" + v);
            gamesList = gamesList.OrderBy(s=>s.Length).ToList();
            Console.WriteLine("\nSorted List:");
            foreach(var v in gamesList) Console.WriteLine("\t" + v);

            Console.ReadKey(true);

        }
    }
}
