namespace SOLID_PRINCIPLES._2_OCP._1_ExWithoutUsingOCP
{
    public class InvoiceWithoutOCP
    {
        /*
          in this example if one more Invoice Type comes into picture then we need to modify the 
          GetInvoiceDiscount() method logic by adding another else if block to the source code.As
          we are changing the source code for the new requirement,we are violating the OCP 
         */
        public double GetInvoiceDiscount(double amount, InvoiceType invoiceType)
        {
            double finalAmount = 0;

            if (invoiceType == InvoiceType.ProposedInvoice)
            {
                finalAmount = amount - 50;
            }
            else if (invoiceType == InvoiceType.FinalInvoice)
            {
                finalAmount = amount - 100;
            }
            return finalAmount;
        }
    }

    public enum InvoiceType
    {
        ProposedInvoice,
        FinalInvoice

    };
}
