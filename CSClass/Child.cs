using System;

namespace CSClass
{
    internal class Child : Parent
    {
        private string v;

        public Child():base(10)
        {
            Console.WriteLine("Child() : base(10)");
        }
        public Child(string input) : base(input)
        {
            Console.WriteLine("Child(input) : base(input)");
        }
    }
}