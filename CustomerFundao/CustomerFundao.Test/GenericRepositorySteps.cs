using CustomerFundao.Domain;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TechTalk.SpecFlow;
using static CustomerFundao.Test.Common.TestHelper;

namespace CustomerFundao.Test
{
    [Binding]
    public class GenericRepositorySteps
    {
        [Given(@"A Context")]
        public void GivenAContext()
        {
            var lista = new List<Customer>()
            {
                new Customer()
            }.AsQueryable();

            var mockSet = Substitute.For<DbSet<Customer>, IQueryable<Customer>>();

            ((IQueryable<Customer>)mockSet).Provider.Returns(lista.Provider);

            //Bag.Context = mockSet.Count();
            Bag.Result = mockSet.AsQueryable().Count();
        }
        
        [Given(@"I add a entity")]
        public void GivenIAddAEntity()
        {
            var context = Bag.Context;
            context.Add(new Customer());
        }
        
        [When(@"Fetch all results")]
        public void WhenFetchAllResults()
        {
            //var context = Bag.Context as DbSet<Customer>;
            //var result = context.Count();
            //Bag.Result = result;
        }
        
        [Then(@"I got (.*) entity")]
        public void ThenIGotEntity(int p0)
        {
            var result = (int)Bag.Result;

            Assert.AreEqual(1, result);
        }
    }
}
