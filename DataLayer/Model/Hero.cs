using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Model
{
    public class Hero
    {
        public int HeroId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual Power Power { get; set; }
        public int PowerId { get; set; }
        public House House { get; set; }
        public int HouseId { get; set; }
    }
}
