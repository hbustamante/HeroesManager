using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Interfaces;
using DataLayer.Model;
using Microsoft.AspNetCore.Mvc;
using SuperHero.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperHero.Controllers
{
    public class HeroController : Controller
    {
        private readonly IHeroRepository _repository;
        private readonly IPowerRepository _powerRepository;

        public HeroController(IHeroRepository repository, IPowerRepository powerRepository)
        {
            _repository = repository;
            _powerRepository = powerRepository;
        }
        [Route("Hero")]
        public IActionResult List(int? powerId, int? houseId)
        {

            var hero = _repository.GetAllWithPower().ToList();

            IEnumerable<Hero> heros;

            ViewBag.PowerId = powerId;

            if (houseId != null)
            {
                heros = _repository.FindWithPowerAndHouse(x => x.HouseId == houseId);
                return CheckHerosCount(heros);
            }

            if (powerId == null)
            {
                heros = _repository.GetAllWithPower();
                return CheckHerosCount(heros);
            }
            else
            {
                var power = _powerRepository.GetWithHero((int)powerId);

                if (power.Heros == null || power.Heros.Count == 0)
                    return View("EmptyPower", power);
            }

            heros = _repository.FindWithPower(a => a.Power.PowerId == powerId);

            return CheckHerosCount(heros);
        }

        private IActionResult CheckHerosCount(IEnumerable<Hero> heros)
        {
            if (heros == null || heros.ToList().Count == 0)
            {
                return View("Empty");
            }
            else
            {
                return View(heros);
            }
        }

        public IActionResult Update(int id)
        {
            Hero hero = _repository.FindWithPower(a => a.PowerId == id).FirstOrDefault();

            if (hero == null)
            {
                return NotFound();
            }

            var heroVM = new HeroEditViewModel
            {
                Hero = hero,
                Powers = _powerRepository.GetAll()
            };

            return View(heroVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(HeroEditViewModel heroVM)
        {
            if (!ModelState.IsValid)
            {
                heroVM.Powers = _powerRepository.GetAll();
                return View(heroVM);
            }
            _repository.Update(heroVM.Hero);

            return RedirectToAction("List");
        }

        public IActionResult Create(int? powerId)
        {
            Hero hero = new Hero();

            if (powerId != null)
            {
                hero.PowerId = (int)powerId;
            }

            var heroVM = new HeroEditViewModel
            {
                Powers = _powerRepository.GetAll(),
                Hero = hero
            };

            return View(heroVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(HeroEditViewModel heroVM)
        {
            if (!ModelState.IsValid)
            {
                heroVM.Powers = _powerRepository.GetAll();
                return View(heroVM);
            }

            _repository.Create(heroVM.Hero);

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id, int? powerId)
        {
            var hero = _repository.GetById(id);

            _repository.Delete(hero);

            return RedirectToAction("List", new { powerId = powerId });
        }
    }
}
