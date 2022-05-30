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


            /*       List<int> list = new List<int>();
                   list.Add(52);
                   list.Add(273);
                   list.Add(73);
                   list.Add(98);*/

            List<int> list = new List<int>() { 52, 273, 73, 98 };
            list.Remove(273);
            list.RemoveAt(0);

            foreach (var item in list) { 
                Console.WriteLine("count : "+list.Count+"\t"+item);
            }


            Console.WriteLine(Math.Abs(-2345));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52,273));
            Console.WriteLine(Math.Min(52,273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            Product product = new Product();
        }
    }
}
