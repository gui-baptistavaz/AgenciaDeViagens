using AgenciaDeViagens.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaDeViagens.Controllers
{
    public class DestinoController : Controller
    {
        private Context _context;

        public DestinoController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var destino = _context.Destino.ToList();
            return View(destino);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Destino destino)
        {
            _context.Add(destino);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id == null)
                return NotFound();

            var destino = _context.Destino.SingleOrDefault(a => a.Id == id);

            if (destino == null)
                return NotFound();

            return View(destino);

        }

        [HttpPost]
        public IActionResult Edit(int id, Destino destino)
        {
            if (id != destino.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(destino);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(destino);
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
                return NotFound();

            var destino = _context.Destino.SingleOrDefault(a => a.Id == id);

            if (destino == null)
                return NotFound();

            return View(destino);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var destino = _context.Destino.SingleOrDefault(a => a.Id == id);

            if (destino == null)
                return NotFound();

            _context.Remove(destino);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            if (id == null)
                return NotFound();

            var destino = _context.Destino.SingleOrDefault(a => a.Id == id);

            if (destino == null)
                return NotFound();

            return View(destino);
        }
    }
}
