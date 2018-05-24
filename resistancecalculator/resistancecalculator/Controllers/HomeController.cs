using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using resistancecalculator.BusinessLogic;
using resistancecalculator.Models;
using resistancecalculator.Services;

namespace resistancecalculator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(CalculatorViewModel cvm)
        {
            OhmValueCalculator oo = new OhmValueCalculator();
            int ohmValue = oo.CalculateOhmValue(cvm.bandAColor,cvm.bandBColor,cvm.bandCColor,cvm.bandDColor);
            BandInfoRepository bandRepo = new BandInfoRepository();
            List<BandSpec> bandColors = bandRepo.GetBandInfo();
            CalculatorViewModel vmCalculator = new CalculatorViewModel()
            {
                bandAColor = cvm.bandAColor,
                bandBColor = cvm.bandBColor,
                bandCColor = cvm.bandCColor,
                bandDColor = cvm.bandDColor,
                BandInfo = bandColors,
                OhmValue = ohmValue
            };
            return View(vmCalculator);
        }
        
    }
}