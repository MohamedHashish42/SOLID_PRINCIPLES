using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID_PRINCIPLES._2_OCP._2_ExWithUsingOCP
{
    class InvoiceWithOCP
    {
        public double GetInvoiceDiscount(double amount, IInvoiceDiscount invoiceDiscount)
        {
           return  invoiceDiscount.GetInvoiceDiscount(amount);
        }
    }
}
