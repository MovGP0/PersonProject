using System;
using NUnit.Framework;
using PersonProject.Model;
using TechTalk.SpecFlow;

namespace PersonProject.Tests
{
    //[Binding]
    //public class PersonStepDefinitions
    //{
    //    [Given(@"I have created a person with FirstName (.*) and LastName (.*)")]
    //    public void GivenIHaveCreatedAPersonWithFirstNameAndLastName(string firstName, string lastName)
    //    {
    //        var person = new Person(0, firstName, lastName, DateTime.UtcNow.Date);
    //        ScenarioContext.Current.Set(person);
    //    }

    //    [Given(@"I have created a person without firstName and LastName (.*)")]
    //    public void GivenIHaveCreatedAPersonWithoutFirstNameAndLastName(string lastName)
    //    {
    //        ScenarioContext.Current["isArgumentNullExceptionForFirstNameThrown"] = false;
    //        try
    //        {
    //            var person = new Person(0, null, lastName, DateTime.Now);
    //            ScenarioContext.Current.Set(person);
    //        }
    //        catch (ArgumentNullException e)
    //        {
    //            if (e.ParamName == "firstName")
    //            ScenarioContext.Current["isArgumentNullExceptionForFirstNameThrown"] = true;
    //        }
    //    }

    //    [Given(@"I have created a person with empty firstName and LastName (.*)")]
    //    public void GivenIHaveCreatedAPersonWithEmptyFirstNameAndLastName(string lastName)
    //    {
    //        ScenarioContext.Current["isArgumentNullExceptionForFirstNameThrown"] = false;
    //        try
    //        {
    //            var person = new Person(0, string.Empty, lastName, DateTime.Now);
    //            ScenarioContext.Current.Set(person);
    //        }
    //        catch (ArgumentNullException e)
    //        {
    //            if (e.ParamName == "firstName")
    //            {
    //                ScenarioContext.Current["isArgumentNullExceptionForFirstNameThrown"] = true;
    //            }
    //        }
    //    }

    //    [Then(@"the FirstName must be (.*)")]
    //    public void ThenTheFirstNameMustBe(string firstName)
    //    {
    //        Assert.AreEqual(firstName, ScenarioContext.Current.Get<Person>().FirstName);
    //    }

    //    [Then(@"the LastName must be (.*)")]
    //    public void ThenTheLastNameMustBe(string lastName)
    //    {
    //        Assert.AreEqual(lastName, ScenarioContext.Current.Get<Person>().LastName);
    //    }

    //    [Then(@"an ArgumentNullException must be thrown")]
    //    public void ThenAnArgumentNullExceptionMustBeThrown()
    //    {
    //        Assert.AreEqual(true, ScenarioContext.Current["isArgumentNullExceptionForFirstNameThrown"]);
    //    }
    //}
}
