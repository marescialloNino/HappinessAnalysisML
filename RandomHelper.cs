using System;
using Accord.Statistics.Distributions.Univariate;

namespace Lecture8
{
    public class RandomHelper
    {
        public static void SlideExample()
        {
            Random rand = new Random(123);
            NormalDistribution normal = new NormalDistribution(0, 1.0);
            Console.WriteLine(DateTime.Now);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(normal.Generate(rand));
            }
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(rand.Next(100) + "\t");
            }
        }
    }
}
