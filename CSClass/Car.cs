using System;

namespace CSClass
{
    internal class Car
    {
        /***
         * carNumber : 자동차 번호
         ***/
        public int carNumber;
        DateTime inTime;
        DateTime outTime;
        
        //자동차 들어온 시간 설정
        public void SetInTime()
        {
           this.inTime = DateTime.Now;
        }

        //자동차가 나간 시간 설정
        public void SetOutTime()
        {
            this.outTime = DateTime.Now;
        }
    }
}