using geneticos2.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geneticos2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            int n = 2;

            Circle[] circles = {

                new Circle { X = -0.85 , Y = 2.45 , R = 2.25    },
                new Circle { X = 2.6, Y = 4.45, R =  2.85 },
                new Circle { X = 6.15 , Y = 0, R = 5.2 },
                new Circle { X = -0.85 , Y = -0.5, R = 3.2  },

            };
            
            double e = 0.005;
            int rounds = 100;
            int size = 500;


            var results = Genetics.calculate(circles, n, rounds, size, e, false);


            sw.Stop();

            Console.WriteLine("Elapsed={0}", sw.Elapsed);

            Console.ReadLine();
        }
    }
}
