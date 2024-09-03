using System;


namespace XayDungLopStopWatch
{
    class CountTime
    {
        public DateTime timeStart;
        public DateTime timeStop;       
        public void Start()
        {
            timeStart = DateTime.Now;
        }
        public void Stop()
        {
            timeStop = DateTime.Now;
        }
        public double GetElapsedTime()
        {
            TimeSpan elapsedTime = timeStop - timeStart;
            long milliseconds = elapsedTime.Ticks / TimeSpan.TicksPerMillisecond;
            return milliseconds;
        }
    }
}