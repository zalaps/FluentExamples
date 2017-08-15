namespace FluentExamples.Models
{
    public class CreateRequest
    {
        public PersonalDetails PersonalDetails { get; set; }
        public PaymentDetails PaymentDetails { get; set; }
        public ProductDetails ProductDetails { get; set; }
    }
}
