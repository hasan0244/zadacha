using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string listOfBeers = "Amstel, Zagorka, Tuborg, Becks.";
            string[] beers = listOfBeers.Split(' ', ',', '.');
            Console.WriteLine("Available beers are:");
            foreach (string beer in beers)
                Console.WriteLine(beer);
        }
    }
}
