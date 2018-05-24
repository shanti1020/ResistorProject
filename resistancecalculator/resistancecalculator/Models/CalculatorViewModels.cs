using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace resistancecalculator.Models
{
  

    public class CalculatorViewModel
    {
        //[FirstColor]
        [Display(Name = "Band A Color")]
        public string bandAColor { get; set; }
        
        [Display(Name = "Band B Color")]
        public string bandBColor { get; set; }
        
        [Display(Name = "Band C Color")]
        public string bandCColor { get; set; }

        [Display(Name = "Band D Color")]
        public string bandDColor { get; set; }

        public float OhmValue { get; set; }

        public IEnumerable<BandSpec> BandInfo { get; set; }
    }
    
}
