namespace InvoiceApi
{
    public class InvoiceService : IInvoiceService
    {
        public Invoice CreateInvoice()
        {
            int ranNum = new Random().Next(1, 15);
            return ranNum > 10
                    ? throw new Exception("Exception in InvoiceService.CreateInvoice.")
                    : new Invoice() { Id = ranNum, PaymentMethod = "PayPal" };
        }
    }
}
