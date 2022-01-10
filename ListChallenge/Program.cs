using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "Will 1", "Will 2", "Ethan", "Adam", "Ben", "Tom", "Cormac", "Ashton", "Henry", "Mr. Dring"};
            List<int> scores = new List<int> { 0, 20, 521, 41, 3, 12, 876, 86, 675, 6};

            Console.WriteLine(names[3]);
        }
    }
}
