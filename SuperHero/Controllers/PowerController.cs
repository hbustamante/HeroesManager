using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataLayer.Interfaces;
using DataLayer.Model;
using SuperHero.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SuperHero.Controllers
{
    public class PowerController : Controller
    {
        private readonly IPowerRepository _repository;

        public PowerController(IPowerRepository repository)
        {
            _repository = repository;
        }
        [Route("Power")]
        public IActionResult List()
        {
            if (!_repository.Any()) return View("Empty");

            var Powers = _repository.GetAllWithHeros();

            return View(Powers);
        }

        public IActionResult PowerDetail()
        {
            var Powers = _repository.GetAllWithHeros();

            if (Powers?.ToList().Count == 0)
            {
                return View("Empty");
            }

            return View(Powers);
        }

        public IActionResult Detail(int id)
        {
            var Power = _repository.GetById(id);

            if (Power == null)
            {
                return NotFound();
            }

            return View(Power);
        }

        public IActionResult Update(int id)
        {
            var Power = _repository.GetById(id);

            if (Power == null)
            {
                return NotFound();
            }

            return View(Power);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Power Power)
        {
            if (!ModelState.IsValid)
            {
                return View(Power);
            }
            _repository.Update(Power);

            return RedirectToAction("List");
        }

        public ViewResult Create()
        {
            return View(new CreatePowerViewModel { Referer = Request.Headers["Referer"].ToString() });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreatePowerViewModel PowerVM)
        {
            if (!ModelState.IsValid)
            {
                return View(PowerVM);
            }

            _repository.Create(PowerVM.Power);

            if (!String.IsNullOrEmpty(PowerVM.Referer))
            {
                return Redirect(PowerVM.Referer);
            }

            return RedirectToAction("List");
        }

        public IActionResult Delete(int id)
        {
            var customer = _repository.GetById(id);

            _repository.Delete(customer);

            return RedirectToAction("List");
        }
    }
}
