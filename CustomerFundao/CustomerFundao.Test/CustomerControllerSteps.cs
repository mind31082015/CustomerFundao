using NUnit.Framework;
using System.Web.Mvc;
using TechTalk.SpecFlow;
using static CustomerFundao.Test.Common.TestHelper;

namespace CustomerFundao.Test
{
    [Binding]
    public class CustomerControllerSteps
    {
        [Given(@"I have a Customer Controller With Index Action")]
        public void GivenIHaveACustomerControllerWithIndexAction()
        {
            var controller = new Controllers.CustomerController();
            Bag.CustomerController = controller;
        }
        
        [When(@"I Request All Customers")]
        public void WhenIRequestAllCustomers()
        {
            var controller = Bag.CustomerController as Controllers.CustomerController;
            var result = controller.Index();
            Bag.Result = result;
        }

        [Then(@"the I should receive a json object")]
        public void ThenTheIShouldReceiveAJsonObject()
        {
            var result = Bag.Result as JsonResult;

            Assert.IsInstanceOf<JsonResult>(result);
        }


    }
}
