using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlluminatiLock
{
    class IlluminatiLock
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var k = 0;

            Console.WriteLine("{0}{1}{0}", new string('.',N), new string('#',N));
            for (int i = 1; i <= N/2; i++)
            {               
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', N-(2*i)), new string('.', k), new string('.', N-2));
                k += 2;
            }
            for (int i = N / 2; i >= 1; i--)
            {
                k -= 2;
                Console.WriteLine("{0}##{1}#{2}#{1}##{0}", new string('.', N - (2 * i)), new string('.', k), new string('.', N - 2));

            }
            Console.WriteLine("{0}{1}{0}", new string('.', N), new string('#', N));
        }
    }
}
