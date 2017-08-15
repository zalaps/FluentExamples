namespace FluentExamples.Models
{
    public class PaymentDetails
    {
        public string PaymentType { get; set; }
        public string PaymentRef { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string BranchCode { get; set; }
        public int DebitDay { get; set; }
    }
}
