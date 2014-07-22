using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using PersonProject.Controllers;
using PersonProject.Model;
using System.Linq;
using System.Data.Entity;
using System.Collections.Generic;
using PersonProject.Models;

namespace PersonProject.Tests
{
    //[TestClass]
    //public class PersonControllerMoqTest
    //{
    //    [TestMethod]
    //    [ExpectedException(typeof(InvalidOperationException))]
    //    public void ControllerDeleteNotExistingEntryMoqTest()
    //    {
    //        // arrange
    //        var controller = CreateMoqTestController();

    //        // act
    //        controller.Delete(2);

    //        // assert
    //        Assert.Fail();
    //    }

    //    [TestMethod]
    //    [ExpectedException(typeof(InvalidOperationException))]
    //    public void ControllerUpdateNotExistingEntryMoqTest()
    //    {
    //        // arrange
    //        var controller = CreateMoqTestController(); 
    //        var person = new Person(27, "Klaus", "Müller", DateTime.Now.Date);

    //        // act
    //        controller.Edit(person.Id, person);

    //        // assert
    //        Assert.Fail();
    //    }

    //    private static PersonController CreateMoqTestController()
    //    {
    //        var mockSet = new Mock<DbSet<Person>>();
    //        var mockContext = new Mock<PeopleContext>();

    //        return CreateMoqTestController(mockSet, mockContext);
    //    }

    //    private static PersonController CreateMoqTestController(Mock<DbSet<Person>> dbSetMock, Mock<PeopleContext> contextMock)
    //    {
    //        if (dbSetMock == null)
    //        {
    //            throw new ArgumentNullException("dbSetMock");
    //        }

    //        if (contextMock == null)
    //        {
    //            throw new ArgumentNullException("contextMock");
    //        }

    //        var data = new List<Person>
    //        {
    //            new Person(0, "Hubert", "Mayer", DateTime.Now.Date),
    //            new Person(1, "Hans", "Müller", DateTime.Now.Date)
    //        }.AsQueryable();

    //        dbSetMock = new Mock<DbSet<Person>>();

    //        dbSetMock.As<IQueryable<Person>>().Setup(m => m.Provider).Returns(data.Provider);
    //        dbSetMock.As<IQueryable<Person>>().Setup(m => m.Expression).Returns(data.Expression);
    //        dbSetMock.As<IQueryable<Person>>().Setup(m => m.ElementType).Returns(data.ElementType);
    //        dbSetMock.As<IQueryable<Person>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

    //        contextMock.Setup(m => m.People).Returns(dbSetMock.Object);
    //        contextMock.Setup(m => m.Dispose());

    //        var repository = new PersonRepository(contextMock.Object);

    //        return new PersonController(() => repository);
    //    }
    //}
}
