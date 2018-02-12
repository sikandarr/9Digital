using System;
using System.IO;
using System.Web;
using _9Digital.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using _9Digital.Models;
using System.Web.Http.Results;
using System.Net.Http;
using System.Web.Http;
using System.Threading.Tasks;

namespace _9DigitalUnitTest
{
    // the automated testing could be imporved using integration testing
    // that will allow the testing of the API controller with web requests
    // ensuring that the output of sending both valid and invalid Json's 
    // adhere to specifications of the coding challenge 

    [TestClass]
    public class ShowsControllerUnitTest
    {
        [TestMethod]
        public void ShouldReturnFilteredResponseModel()
        {
            //desrialize the sample json to Request object
            Request payload = JsonConvert.DeserializeObject<Request>(File.ReadAllText(@"sample_request.json"));
            //deserialize sample json output to ResponseModel object
            ResponseModel expected = JsonConvert.DeserializeObject<ResponseModel>(File.ReadAllText(@"sample_response.json"));

            //Arrange
            var controller = new ShowsController();
            controller.Request = new HttpRequestMessage();
            controller.Configuration = new HttpConfiguration();

            //Act
            var response = controller.PostShow(payload);

            //Assert
            response.TryGetContentValue<ResponseModel>(out ResponseModel actual);
            Assert.AreEqual(expected.Response.Length, actual.Response.Length);
            for (int i=0; i<expected.Response.Length; i++)
            {
                Assert.AreEqual(expected.Response[i].Image, actual.Response[i].Image);
                Assert.AreEqual(expected.Response[i].Slug, actual.Response[i].Slug);
                Assert.AreEqual(expected.Response[i].Title, actual.Response[i].Title);
            }
        }
    }
}
