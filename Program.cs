using FluentExamples.Models;
using FluentExamples.Vetting;
using FluentValidation;
using System;
using System.Text;

namespace FluentExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalDetails = new PersonalDetails();
            personalDetails.EmailAddress = null;        //In Use
            personalDetails.FirstName = "fname";
            personalDetails.LastName = "lname";
            personalDetails.MSISDN = "7865";
            personalDetails.Password = "";

            var productDetails = new ProductDetails();
            productDetails.AdditionalEquipment = true;
            productDetails.DealId = 64;
            productDetails.EquipmentDescription = "this is desc";
            productDetails.ModelId = "";            //In Use
            productDetails.PayMethodId = 8979;
            productDetails.Subscription = null;

            var paymentDetails = new PaymentDetails();
            paymentDetails.AccountNumber = "1234";
            paymentDetails.AccountType = " ";           //In Use
            paymentDetails.BankName = "Federal";
            paymentDetails.BranchCode = null;
            paymentDetails.DebitDay = 15;
            paymentDetails.PaymentRef = "kjh87";
            paymentDetails.PaymentType = "Direct";

            var createRequest = new CreateRequest();
            createRequest.PersonalDetails = personalDetails;
            createRequest.ProductDetails = productDetails;
            createRequest.PaymentDetails = paymentDetails;

            #region BareBasic
            //var bareBasicValidator = new BareBasicValidator();
            //Breaks the code and throws exception
            //personalDetailsValidator.ValidateAndThrow(personalDetails);
            //var results = bareBasicValidator.Validate(personalDetails);
            #endregion

            #region ComplexType
            //var complexTypeValidator = new ComplexTypeValidator();
            //var results = complexTypeValidator.Validate(createRequest);
            #endregion

            #region RuleSet
            var ruleSetValidator = new RuleSetValidator();

            //This is how named rulesets are called
            var results = ruleSetValidator.Validate(createRequest, ruleSet: "TopUp");
            //var results = ruleSetValidator.Validate(createRequest, ruleSet: "Credit");
            //var results = ruleSetValidator.Validate(createRequest, ruleSet: "TopUp,Credit");

            //This will call all unnamed rules
            //var results = ruleSetValidator.Validate(createRequest);
            #endregion

            var error = new StringBuilder();
            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    error.Append(failure.ErrorMessage);
                }
            }
            Console.WriteLine(error.ToString());
        }
    }
}
