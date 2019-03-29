using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Model
{
    public class Power
    {
        public int PowerId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Hero> Heros { get; set; }
    }
}
