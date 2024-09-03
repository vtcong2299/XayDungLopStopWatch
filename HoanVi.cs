using System;


namespace XayDungLopStopWatch
{
    class HoanVi
    {
        public void HoanViSo(ref int num1, ref int num2)
        {
            int bienTam = num1;
            num1= num2;
            num2 = bienTam;
        }
    }
}