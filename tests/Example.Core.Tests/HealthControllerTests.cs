using Example.Core.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace Example.Core.Tests
{
    public class HealthControllerTests
    {
        [Fact]
        public void HealthCheckIsOk()
        {
            var sut = new HealthController();
            var result = sut.GetHealth() as OkObjectResult;
            Assert.NotNull(result);
            Assert.Equal(true, result.Value);
        }
    }
}
