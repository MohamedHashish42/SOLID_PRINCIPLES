namespace SOLID_PRINCIPLES._2_OCP._2_ExWithUsingOCP
{
    class ProposedInvoice : IInvoiceDiscount
    {
        public double GetInvoiceDiscount(double amount)
        {
            return amount - 50;
        }
    }
}
