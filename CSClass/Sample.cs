using System;

namespace CSClass
{
    internal class Sample
    {
        internal static int value=10;

        static Sample()
        {
            value = 20;
            Console.WriteLine("정적 생성자 호출");
        }
    }
}