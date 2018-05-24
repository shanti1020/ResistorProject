using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using resistancecalculator.Models;

namespace resistancecalculator.BusinessLogic
{
    public class BandInfoRepository
    {
        public List<BandSpec> GetBandInfo()
        {
            List<BandSpec> bandColors = new List<BandSpec>();
        bandColors.Add(new BandSpec { Color = "Pink", SignificantFigures = null, Multiplier = (float) 0.001, TolerancePercent = 20});
            bandColors.Add(new BandSpec { Color = "Siver", SignificantFigures = null, Multiplier = (float) 0.01, TolerancePercent = 10 });
            bandColors.Add(new BandSpec { Color = "Gold", SignificantFigures = null, Multiplier = (float)0.1, TolerancePercent = 5 });
            bandColors.Add(new BandSpec { Color = "Black", SignificantFigures = 0, Multiplier = 1, TolerancePercent = 20 });
            bandColors.Add(new BandSpec { Color = "Brown", SignificantFigures = 1, Multiplier = 10, TolerancePercent = 1 });
            bandColors.Add(new BandSpec { Color = "Red", SignificantFigures = 2, Multiplier = 100, TolerancePercent = 2 });
            bandColors.Add(new BandSpec { Color = "Orange", SignificantFigures = 3, Multiplier = 1000, TolerancePercent = 20});
            bandColors.Add(new BandSpec { Color = "Yellow", SignificantFigures = 4, Multiplier = 10000, TolerancePercent =5 });
            bandColors.Add(new BandSpec { Color = "Green", SignificantFigures = 5, Multiplier = 100000, TolerancePercent = (float)0.5 });
            bandColors.Add(new BandSpec { Color = "Blue", SignificantFigures = 6, Multiplier = 1000000, TolerancePercent = (float)0.25 });
            bandColors.Add(new BandSpec { Color = "Violet", SignificantFigures = 7, Multiplier = 10000000, TolerancePercent = (float)0.1 });
            bandColors.Add(new BandSpec { Color = "Gray", SignificantFigures = 8, Multiplier = 100000000, TolerancePercent = (float)0.05 });
            bandColors.Add(new BandSpec { Color = "White", SignificantFigures = 9, Multiplier = 1000000000, TolerancePercent = 20 });
            
            return bandColors;

        }
    }
}