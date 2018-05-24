using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace resistancecalculator.Models
{
    public class BandSpec
    {
        public string Color { get; set; }
        //public string Code { get; set; }
        //public string RAL { get; set; }
        public int? SignificantFigures { get; set; }
        public float Multiplier { get; set; }
        public float TolerancePercent { get; set; }
    }
}