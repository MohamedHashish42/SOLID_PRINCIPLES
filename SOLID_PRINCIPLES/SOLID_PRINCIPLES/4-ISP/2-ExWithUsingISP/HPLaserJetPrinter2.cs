using System;

namespace SOLID_PRINCIPLES._4_ISP._2_ExWithUsingISP
{
    class HPLaserJetPrinter2 : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            throw new NotImplementedException();
        }
        public void Scan(string ScanContent)
        {
            throw new NotImplementedException();
        }
        public void Fax(string content)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplex(string content)
        {
            throw new NotImplementedException();
        }
    }
}
