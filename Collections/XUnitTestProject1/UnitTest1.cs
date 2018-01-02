using System;
using Xunit;
using Collections;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestingTest()
        {
            Assert.Equal("1", Program.TestingTest());
        }
    }
}
