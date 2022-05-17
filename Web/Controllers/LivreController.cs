using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Livre;
using System.Collections.Generic;

namespace Web.Controllers
{
    public class LivreController : Controller

    {

        private readonly ILivreService _livreService;

        public LivreController(ILivreService livreService)
        {
            _livreService = livreService;
        }


        // GET: LivreController
        public ActionResult Index()
        {
            List<Livre> livres = (List<Livre>)_livreService.GetMany();
            return View(livres);
        }

        // GET: LivreController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LivreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LivreController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LivreController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LivreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LivreController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
