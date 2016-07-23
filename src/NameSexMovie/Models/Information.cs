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
        [RegularExpression(@"^ ([a - z] +[,.]?[ ] ?|[a - z] +['-]?)+$)")]
        public string name { get; set; }
        [RegularExpression(@"^([Male|[Female)$")]
        public string gender { get; set; }
        [StringLength(60, MinimumLength =2)]
        [RegularExpression (@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string movie { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string book { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string music { get; set; }
        [StringLength(60, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$")]
        public string food { get; set; }
        [RegularExpression(@"^\d{1,2}$")]
        public int age { get; set; }
    }
}
