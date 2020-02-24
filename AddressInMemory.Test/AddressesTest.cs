using System;
using Xunit;
using AddressInMemory.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using AddressInMemory.Controllers;
using System.Collections.Generic;

namespace AddressInMemory.Test
{
    public class AddressesTest
    {
        //[Fact]
        //public void Test1()
        //{
        //    // Arrange
        //    var options = new Mock<DbContextOptions<APIContext>>();
        //    APIContext obj = new APIContext(options.Object);

        //    // Act 
        //    var address = obj.GetAllAddreeess();

        //    // Assert
        //    Assert.NotEmpty(address);
        //}

        [Fact]
        public void Test1()
        {
            var context = new Mock<APIContext>();
            context.Setup(x => x.GetAllAddreeess()).Returns(new List<Address>());

            // Arrange
            AddressesController obj = new AddressesController(context.Object);

            // Act 
            var address = obj.GetAddressess();

            // Assert
            Assert.NotNull(address);
        }


    }
}
