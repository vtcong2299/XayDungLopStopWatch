using System;


namespace XayDungLopStopWatch
{
    class Program
    {
        static void Main(string[]args)
        {
            CountTime countTime = new CountTime();    
            countTime.Start();        
            Random rand= new Random();
            int [] array= new int[100000];
            for (int i=0;i<100000;i++)
            {
                array[i]= rand.Next(0,100000);
            }       
            SapXep sapXep = new SapXep();            
            sapXep.SapXepTangDan(array);
            foreach(int num in array)
            {
                Console.Write("{0,10}",num);
            }
            Console.WriteLine();
            countTime.Stop();
            Console.WriteLine("Tong thoi gian thuc hien chuong trinh la: "+ countTime.GetElapsedTime()+" Mili giay");
        }
    }
}