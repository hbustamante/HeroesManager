using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataLayer.Model
{
    public class House
    {
        public int HouseId { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
