using DataLayer.Model;
using System.Collections.Generic;

namespace SuperHero.ViewModels
{
    public class HeroEditViewModel
    {
        public Hero Hero { get; set; }

        public IEnumerable<Power> Powers { get; set; }
    }
}
