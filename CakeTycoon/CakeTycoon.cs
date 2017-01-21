using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeTycoon
{
    class CakeTycoon
    {
        static void Main(string[] args)
        {
            var cakes = int.Parse(Console.ReadLine());
            var flourNeed = decimal.Parse(Console.ReadLine());
            var flour = int.Parse(Console.ReadLine());
            var truffel = long.Parse(Console.ReadLine());
            var truffelPrice = long.Parse(Console.ReadLine());



            var kg = cakes * flourNeed;
            if (kg<=flour)
            {
                Console.WriteLine( "All products available, price of a cake: {0:f2}",Math.Round((truffel*truffelPrice)/(double)cakes*1.25,2));
            }
            else
            {
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", Math.Floor(flour/flourNeed),kg-flour);
            }
        }
    }
}
