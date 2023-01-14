using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnimalEncyclopedia.Models
{
    public class AnimalsModel
    {

        public IEnumerable<AnimalEncyclopedia.Models.Amphibian> Amphibians { get; set; }
        public IEnumerable<AnimalEncyclopedia.Models.Bird>Birds  { get; set; }
        public IEnumerable<AnimalEncyclopedia.Models.Animal> Animals { get; set; }


    }
}