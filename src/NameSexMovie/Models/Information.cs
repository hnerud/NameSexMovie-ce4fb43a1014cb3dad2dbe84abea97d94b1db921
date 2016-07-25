using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NameSexMovie.Models
{
    public class Information
    {
        internal static object category;

        public int ID { get; set; }
        [RegularExpression(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$", ErrorMessage = "Make sure you capitalize")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Name can not be empty")]
        public string name { get; set; }
        [RegularExpression(@"^([M|m]ale|[F|f]emale)$", ErrorMessage = "How in the world did you manage to goof this one up??")]
        public string gender { get; set; }
        [StringLength(60, MinimumLength =2, ErrorMessage = "Movie must have minimum 2 and maximum 60 character!")]
        [RegularExpression (@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Don't you know how to type a movie title?")]
        public string movie { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Book must have minimum 2 and maximum 60 character!")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z''-'\s]*$", ErrorMessage = "Don't you know how to enter a book title?")]
        public string book { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "Music must have minimum 2 and maximum 60 character!")]
        public string music { get; set; }
        [StringLength(60, MinimumLength = 2, ErrorMessage = "food must have minimum 2 and maximum 60 character!")]
        public string food { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your age")]
        [RegularExpression(@"^\d{1,2}$",ErrorMessage ="You must enter an age between 1 and 99")]
        public int age { get; set; }
    }
}
