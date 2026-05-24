using Xunit;

namespace DeployToAzure.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var result = 1 + 2;

            Assert.Equal(3, result);

        }
    }
}