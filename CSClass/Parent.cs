﻿using System;

namespace CSClass
{
    internal class Parent
    {
        public Parent() {
            Console.WriteLine("Parent()");
        }
        public Parent(int param)
        {
            Console.WriteLine("Parent(int param)");
        }

        public Parent(string input)
        {
            Console.WriteLine("Parent(string param)");
        }
    }
}