using Example.Core.BusinessLogic;
using Xunit;

namespace Example.Core.Tests
{
    public class HealthCheckProviderTests
    {
        [Fact]
        public void CheckHealthIsTrue()
        {
            Assert.True(HealthCheckProvider.CheckHealth);
        }
    }
}