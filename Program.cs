using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2._21_Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Songs holiday = new Songs("Holiday", "Green Day", 4);
            Songs kashmir = new Songs("Kashmir", "Led Zeppelin", 5);

            Console.Write(Songs.songCount);
            Console.ReadKey();

        }
    }
}
