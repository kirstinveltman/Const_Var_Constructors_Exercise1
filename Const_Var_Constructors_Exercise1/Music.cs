using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const_Var_Constructors_Exercise1
{
    class Music
    {
        public Music(string name) : this(name, 1994)
        {
        }

        public Music(string song, int yearMade)
        {
            Song = song;
            YearMade = yearMade;
            Console.WriteLine("This song, " + song + " was created in the year " + yearMade + ".");
        }

        public string Song { get; set; }
        public int YearMade { get; set; }

    }
}
