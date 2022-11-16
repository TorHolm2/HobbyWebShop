using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DataService.Controllers
{
    public class ProdcutController : Controller
    {
        // GET: ProdcutController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ProdcutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProdcutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProdcutController/Create
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

        // GET: ProdcutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProdcutController/Edit/5
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

        // GET: ProdcutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProdcutController/Delete/5
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
