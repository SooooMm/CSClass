﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSClass
{
    internal class Program
    {
        public static int number = 10;

        static void Main()
        {
            Car car = new Car();
            car.SetInTime();
            car.SetOutTime();

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));

            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10);


            /*       List<int> list = new List<int>();
                   list.Add(52);
                   list.Add(273);
                   list.Add(73);
                   list.Add(98);*/

            List<int> list = new List<int>() { 52, 273, 73, 98 };
            list.Remove(273);
            list.RemoveAt(0);

            foreach (var item in list) {
                Console.WriteLine("count : " + list.Count + "\t" + item);
            }


            Console.WriteLine(Math.Abs(-2345));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52, 273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));
            Console.WriteLine(Math.PI);

            /*           Product product = new Product();
                       product.name = "고구마";
                       product.price = 6000;
                Console.WriteLine(product.name+" : "+product.price);
            
             */

            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { price = 2000, name = "감자" };
            Product productC = new Product() { name = "감자" };


            Console.WriteLine(productA);
            Console.WriteLine(productB);
            Console.WriteLine(productC);

            List<Student> students = new List<Student>()
            {
            new Student() { name = "홍마마", grade = 98 },
            new Student() { name = "가수연", grade = 23 },
            new Student() { name = "김예수", grade = 33 },
            new Student() { name = "이진수", grade = 80 },
            new Student() { name = "개인기", grade = 3 },
            new Student() { name = "나구연", grade = 40 },
            new Student() { name = "남민기", grade = 68 },
            new Student() { name = "행부부", grade = 73 },
            new Student() { name = "민지킹", grade = 34 },
            new Student() { name = "수쿠기", grade = 55 },
            };

            /*
            foreach (var student in students)
            {
                if (student.grade > 60) {
                    students.Remove(student);
                }
            }
            */

            for (int i = students.Count-1; i>=0  ; i--) 
            {
                if (students[i].grade > 60) { 
                    students.RemoveAt(i);
                }
            }
            foreach (var student in students)
            { 
                Console.WriteLine(student.ToString());
            }
           
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));
            Console.WriteLine(MyMath.Abs(-52));

            Product productX = new Product("감자", 2000);
            Product productY = new Product("고구마", 3000);

            Console.WriteLine(productX.ToString());
            Console.WriteLine(productY.ToString());
            Console.WriteLine(Product.counter + "개가 생성되었습니다.");

            SingleTon mySingle = SingleTon.getInstance();

            Console.WriteLine("첫번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세번째 위치");

            Product product = new Product("과자",1500);
            product = null;

            Box box = new Box(10, 20);
            box.Width = 100;
            box.Height = 200;
            Console.WriteLine(box.Area);

            box.Width = -10;
            box.Height = 300;
            Console.WriteLine(box.Area);

            Box box2 = new Box(-10, -20);
            Console.WriteLine(box2.Area);

            /*
            //Finbonacci fibo = new Finbonacci();
            Console.WriteLine(Finbonacci.Get(1));
            Console.WriteLine(Finbonacci.Get(2));
            Console.WriteLine(Finbonacci.Get(3));
            Console.WriteLine(Finbonacci.Get(4));
            Console.WriteLine(Finbonacci.Get(5));
            Console.WriteLine(Finbonacci.Get(10));
            Console.WriteLine(Finbonacci.Get(50));
            */

            //Cat cat = new Cat();
            //Dog dog = new Dog();

            List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
            List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };
            List<Animal> Animals = new List<Animal>() {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat() 
            };
            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                if(item is Dog)((Dog)item).Bark(); //객체가 Dog이라면
                if (item is Cat) ((Cat)item).Meow();
                //item is Animal //Animal로써의 역할을 할 수 있는지

                
                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }


            Child ChildA = new Child();
            Child ChildB = new Child("String");

            int number = 20;
            Console.WriteLine(number);

            foreach (var item in Animals) { 
                item.Eat();
            }
        }
    }
}
