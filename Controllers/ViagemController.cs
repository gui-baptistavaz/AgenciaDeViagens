using Microsoft.AspNetCore.Mvc;
using AgenciaDeViagens.Models;

namespace AgenciaDeViagens.Controllers
{
    public class ViagemController : Controller
    {
        private Context _context;
        public ViagemController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var viagem = _context.Viagem.ToList();
            return View(viagem);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Viagem viagem)
        {
            _context.Add(viagem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id == null)
                return NotFound();

            var viagem = _context.Viagem.SingleOrDefault(a => a.Id == id);

            if (viagem == null)
                return NotFound();

            return View(viagem);

        }

        [HttpPost]
        public IActionResult Edit(int id, Viagem viagem)
        {
            if (id != viagem.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(viagem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(viagem);
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
                return NotFound();

            var viagem = _context.Viagem.SingleOrDefault(a => a.Id == id);

            if (viagem == null)
                return NotFound();

            return View(viagem);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var viagem = _context.Viagem.SingleOrDefault(a => a.Id == id);

            if (viagem == null)
                return NotFound();

            _context.Remove(viagem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
