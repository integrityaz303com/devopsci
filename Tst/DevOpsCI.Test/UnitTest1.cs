using System;
using Xunit;
using DevOpsCI.Controllers;

namespace DevOpsCI.Test
{
    public class UnitTest1
    {
        
        ValuesController controller = new ValuesController();

        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);

            Assert.Equal("Edu Ongeso", returnValue.Value); 
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
