using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NameSexMovie.Models
{
    public class InformationViewModel
    {
        public List<Information> information;
        public SelectList selectedCategory;

        public string subcategory { get; set; }

        public string category { get; set; }
    }
}
