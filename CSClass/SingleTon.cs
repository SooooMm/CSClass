using System;

namespace CSClass
{
    internal class SingleTon
    {
        private static SingleTon instance = null;
        private SingleTon()
        {
        }

        internal static SingleTon getInstance()
        {
            if (instance == null) { 
                instance = new SingleTon();
            }
            return instance;
        }
    }
}