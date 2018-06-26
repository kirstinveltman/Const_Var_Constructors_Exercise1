using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Constructors_Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            const string artistName = "The Beatles";
            Console.WriteLine("One of my favorite bands is {0}.", artistName);

            string song = "Let It Be";
            int yearMade = 1970;
            var newMusic = new Music(song, yearMade);

            Console.ReadLine();

        }
    }
}
