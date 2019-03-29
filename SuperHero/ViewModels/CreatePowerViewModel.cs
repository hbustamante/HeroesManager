using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHero.ViewModels
{
    public class CreatePowerViewModel
    {
        [Required]
        public Power Power { get; set; }
        public string Referer { get; set; }
    }
}
