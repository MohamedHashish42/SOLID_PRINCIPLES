using System;

namespace SOLID_PRINCIPLES._4_ISP._2_ExWithUsingISP
{
    class LiquidInkjetPrinter2 : IPrinterTasks
    {

        public void Print(string PrintContent)
        {
            throw new NotImplementedException();
        }

        public void Scan(string ScanContent)
        {
            throw new NotImplementedException();
        }
    }
}
