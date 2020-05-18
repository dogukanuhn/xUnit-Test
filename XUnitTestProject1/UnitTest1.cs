
using DataServices;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Bson;
using Moq;
using Newtonsoft.Json;
using pracitices.Entity.Model;
using practices.web.Controllers;
using System;
using Xunit;


namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Fact]
        public void GetData_ShouldData_ObjectId()
        {
            var data = new Data
            {
                BookName = "Clean Code",
                Price = (decimal)43.15,
                Category = "Computers",
                Author = "Robert C. Martin",
                Id = new ObjectId("5ec1c3848536fcd209247839")
            };
            var utilityServiceMock = new Mock<IDataService>();
            var serviceProvider = new ServiceCollection().BuildServiceProvider();
            utilityServiceMock.Setup(u => u.GetData("5ec1c3848536fcd209247839")).Returns(data);


            Assert.Equal(data, utilityServiceMock.Object.GetData("5ec1c3848536fcd209247839"));

        }

        [Fact]
        public void Insert_ShouldData_Data()
        {
            var data = new Data
            {
                BookName = "Writing Poem",
                Price = (decimal)30.5,
                Category = "Poetry",
                Author = "Dogukan R.R Martin"
            };
            var utilityServiceMock = new Mock<IDataService>();
            var serviceProvider = new ServiceCollection().BuildServiceProvider();
            utilityServiceMock.Setup(u => u.Insert(data)).Returns(data);


            Assert.IsType<Data>(utilityServiceMock.Object.Insert(data));

        }
    }
}
