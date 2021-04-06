namespace SOLID_PRINCIPLES._2_OCP._2_ExWithUsingOCP
{
    class FinalInvoice : IInvoiceDiscount
    {

        public double GetInvoiceDiscount(double amount)
        {
            return amount - 100;
        }
    }
}
