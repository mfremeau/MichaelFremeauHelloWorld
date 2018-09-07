using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FremeauAPI.Controllers;
using FremeauAPI.Models;
using System.Web.Http;
using System.Web.Http.Results;
using System.Threading.Tasks;

namespace FremeauAPI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Get_ReturnsAllFremeaus()
        {
            var testFremeaus = this.TestFremeaus;

            var result = (List<FremeauModel>)new FremeauController().Get();
            Assert.AreEqual(testFremeaus.Count, result.Count);
        }
        
        [TestMethod]
        public void Get_CorrenctIndividualFremeau()
        {
            var testFremeau = this.TestFremeaus.Find(w => w.id == 1); 

            var result = (OkNegotiatedContentResult<FremeauModel>)new FremeauController().Get(1);
            Assert.IsNotNull(result);
            Assert.AreEqual(testFremeau.Name, result.Content.Name);
        }

        [TestMethod]
        public void Get_DoesNotFindProduct ()
        {
            var result = new FremeauController().Get(941);
            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }

        private List<FremeauModel> TestFremeaus = new List<FremeauModel>
        {
            new FremeauModel {
                id = 1,
                Name = "Hello World"
            }
        };

        [TestMethod]
        public async Task GetAsync_ReturnsAllFremeaus ()
        {
            var testFremeaus = this.TestFremeaus;

            var fremeauController = new FremeauController();
            var result = await fremeauController.GetAsync() as List<FremeauModel>;
            Assert.AreEqual(testFremeaus.Count, result.Count);
        }

        [TestMethod]
        public async Task GetASync_CorrectIndividualFremeau ()
        {

            var testFremeau = this.TestFremeaus.Find(w => w.id == 1);

            var result = await new FremeauController().GetAsync(1) as OkNegotiatedContentResult<FremeauModel>;
            Assert.IsNotNull(result);
            Assert.AreEqual(testFremeau.Name, result.Content.Name);
        }
    }
}
