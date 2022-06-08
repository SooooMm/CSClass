using System;

namespace CSClass
{
    internal class Product
    {
        public static int counter =0;
        public string name;
        public int price=1000;
        private int id;

        public Product() { 
        
        }
        public Product(string name, int price)
        {
            this.id = counter++;
            this.price = price;
            this.name = name;
        }

        public override string ToString()
        {
            return "["+this.id+"] "+  this.name + " : " +this.price;
        }

        ~Product(){
            Console.WriteLine(this.name + "의 소멸자 호출");
        }

    }
}