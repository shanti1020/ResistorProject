using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using resistancecalculator;
using resistancecalculator.BusinessLogic;
using resistancecalculator.Controllers;
using resistancecalculator.Models;

namespace resistancecalculator.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            BandInfoRepository bandRepo = new BandInfoRepository();
            List<BandSpec> bandColors = bandRepo.GetBandInfo();

            CalculatorViewModel vmCalculator = new CalculatorViewModel()
            {
                bandAColor = "Red",
                bandBColor = "Red",
                bandCColor = "Red",
                bandDColor = "Red",
                BandInfo = null,
                OhmValue = 0
            };

            // Act
            ViewResult result = controller.Index(vmCalculator) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        
    }
}
