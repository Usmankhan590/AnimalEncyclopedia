using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalEncyclopedia.Models
{
    public class ViewModel
    {
        public  IEnumerable<AnimalEncyclopedia.Models.card> Cards { get; set; }
        public IEnumerable<AnimalEncyclopedia.Models.research> Researches { get; set; }

    }
}