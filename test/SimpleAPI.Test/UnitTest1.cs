using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {

        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(123);
            Assert.Equal("My Name", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
