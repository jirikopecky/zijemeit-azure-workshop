using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SampleWebApp.Tests
{
    public sealed class HelloWorldTests : IDisposable
    {
        private TestServer _server;
        private HttpClient _client;

        public HelloWorldTests()
        {
            _server = new TestServer(new WebHostBuilder()
            .UseStartup<Startup>());
            _client = _server.CreateClient();
        }

        public void Dispose()
        {
            _client?.Dispose();
            _client = null;

            _server?.Dispose();
            _server = null;
        }

        [Fact]
        public async Task SampleDataControllerReturnsCorrectValueTest()
        {
            // Act
            var response = await _client.GetAsync("/api/sampleData/");
            response.EnsureSuccessStatusCode();

            var responseString = await response.Content.ReadAsStringAsync();
            var responseObject = JObject.Parse(responseString);

            // Assert

            Assert.Equal("Hello, World!", responseObject["message"]?.ToString());
        }
    }
}
