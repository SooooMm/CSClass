using System;

namespace CSClass
{
    internal class MyMath
    {
        int some_int = 3;
        /// <summary>
        /// 절대값 구하는 클래스 메서드
        /// </summary>
        /// <param name="v"></param>
        /// <returns></returns>
        static int  Abs(int v)
        {
            //foo(); //인스턴스 클래스 메서드에서 사용 불가
            return (v < 0) ? -1 : v;
        }

        void foo() {
            Console.WriteLine("클래스 메서드에서 접근 불가");
        }
    }
}