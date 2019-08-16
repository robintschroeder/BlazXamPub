using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace MSC.BlazXam.BizLogicTest
{
    [TestClass]
    public class TestHTTPClientService
    {
        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestInitialize]
        public void Setup()
        {
        }

        [TestMethod]
        public async Task TestGetAccuWeatherCurrentWeatherData()
        {
            //locationId = 349727 - should be new york
            var reply = await MSC.BlazXam.BizLogic.HTTPClientService.GetAccuWeatherCurrentConditionsDataAsync("349727");

            Assert.AreEqual(true, !string.IsNullOrEmpty(reply.Link));
        }

        [TestMethod]
        public async Task TestGetAccuWeatherTopCitiesData()
        {
            var reply = await MSC.BlazXam.BizLogic.HTTPClientService.GetAccuWeatherTopCitiesDataAsync();

            Assert.AreEqual(true, reply.Count == 50);
        }
    }
}