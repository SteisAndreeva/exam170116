using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerStock
{
    class BeerStock
    {
        static void Main(string[] args)
        {
            var reserved = int.Parse(Console.ReadLine());

            long totalamount = 0;
            string comand =Console.ReadLine();

            while (comand != "Exam Over")
            {
                    string[] words = comand.Split();
                    long amount =long.Parse(words[0]);
                    string type = words[1];
                    switch (type)
                    {
                        case "beers": totalamount += amount; break;
                        case "sixpacks": totalamount += amount * 6; break;
                        case "cases": totalamount += amount * 24; break;
                    }
                comand = Console.ReadLine();
            }

                totalamount = totalamount - (totalamount / 100);


            if (totalamount>=reserved)
            {
                long restamount = totalamount - reserved;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", restamount/24, (restamount% 24)/6, (restamount % 24) % 6);
            }
            else
            {
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.",(reserved-totalamount) / 24, ((reserved-totalamount) % 24) / 6, ((reserved-totalamount) % 24) % 6);
            }
        }
    }
}
