using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using Microsoft.AspNetCore.Mvc;
using SuperHero.Models;
using SuperHero.ViewModels;

namespace SuperHero.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHeroRepository _heroRepository;
        private readonly IPowerRepository _powerRepository;
        private readonly IHouseRepository _houseRepository;

        public HomeController(IHeroRepository heroRepository, IPowerRepository powerRepository, IHouseRepository houseRepository)
        {
            _heroRepository = heroRepository;
            _powerRepository = powerRepository;
            _houseRepository = houseRepository;
        }
        public IActionResult Index()
        {
            var homeVM = new HomeViewModel
            {
                HousesCount = _houseRepository.Count(x => true),
                PowersCount = _powerRepository.Count(x => true),
                HerosCount = _heroRepository.Count(x => true),
            };

            return View(homeVM);
        }
    }
}
