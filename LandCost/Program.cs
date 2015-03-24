using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LandCost
{
    // Calculate cost of a rectangle of given length of two sides
    class Program
    {
        static void Main(string[] args)
        {
            // get the length & width of the parcel
            Console.WriteLine("Enter the width of the parcel of land in feet");
            decimal width = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Enter the length of the parcel of land in feet");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // cost is $5 per square yard plus $.75 per foot of perimeter
            decimal cost = (2 * length * .75m + 2 * width * .75m ) + ((length * width /9) * 5);

            Console.WriteLine("The land cost is: " + cost);
            Console.ReadLine();

        }
    }
}
