using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_PRINCIPLES._4_ISP._1_ExWithoutUsingISP
{
    interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
        void Fax(string FaxContent);
        void PrintDuplex(string PrintDuplexContent);
    }
}
