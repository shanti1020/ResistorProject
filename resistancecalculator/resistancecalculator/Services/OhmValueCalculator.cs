using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using resistancecalculator.Contracts;
using resistancecalculator.Models;
using resistancecalculator.BusinessLogic;

namespace resistancecalculator.Services
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            //throw new NotImplementedException();
            BandInfoRepository bandRepo = new BandInfoRepository();
            List<BandSpec> bandColors = bandRepo.GetBandInfo();
            int ohmValue = 0;
            if (bandAColor != null && bandBColor != null && bandCColor != null && bandDColor != null)
            {
                var ohmValuetemp = 
                    Int64.Parse(
                        string.Concat(bandColors.First(w => w.Color == bandAColor).SignificantFigures.ToString(),
                            bandColors.First(w => w.Color == bandBColor).SignificantFigures.ToString()))*
                     bandColors.First(w => w.Color == bandCColor).Multiplier;
                //} )+bandColors.Where(x=>x.Color==bandBColor))
                ohmValue = (int) ohmValuetemp;
            }

            return ohmValue;
        }
    }
}