using GeoLibContracts;
using GeoLibRespositories;
using GeoLibServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace GeoLibTest
{
    [TestClass]
    public class GeoManagerTest
    {
        [TestMethod]
        public void ZipCodeRetrieval()
        {
            Mock<IZipCodeRepository> mockZipCodeRepo = new Mock<IZipCodeRepository>();

            ZipCode zipCode = new ZipCode()
            {
                City = "Mock City",
                State = "Mock State",
                Zip = "Mock Zip"
            };

            mockZipCodeRepo.Setup(obj => obj.GetZipInfo("Mock Zip")).Returns(zipCode);

            IGeoService geoService = new GeoManager(mockZipCodeRepo.Object);

            ZipCodeData zipCodeData = geoService.GetZipInfo("Mock Zip");

            Assert.IsTrue(zipCodeData.City == zipCode.City);
            Assert.IsTrue(zipCodeData.State == zipCode.State);
            Assert.IsTrue(zipCodeData.Zip == zipCode.Zip);
        }
    }
}
