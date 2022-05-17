using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSClass
{
    internal static class Program
    {
        static void Main()
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));
            Console.WriteLine(random.Next(10,100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble()*10);
        }
    }
}
