using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NameSexMovie.Models
{
    public class Information
    {
        public int ID { get; set; }
        [RegularExpression(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$")]
        public string name { get; set; }
        [RegularExpression(@"^([M|m]ale|[F|f]emale)$")]
        public string gender { get; set; }
        [StringLength(60, MinimumLength =2)]
        [RegularExpression (@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string movie { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string book { get; set; }
        [StringLength(60, MinimumLength = 2)]
        public string music { get; set; }
        [StringLength(60, MinimumLength = 2)]
        public string food { get; set; }
        [RegularExpression(@"^\d{1,2}$")]
        public int age { get; set; }
    }
}
