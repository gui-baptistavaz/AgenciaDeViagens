using AgenciaDeViagens.Models;
using Microsoft.AspNetCore.Mvc;

namespace AgenciaDeViagens.Controllers
{
    public class ClienteController : Controller
    {
        private Context _context;

        public ClienteController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var cliente = _context.Cliente.ToList();

            return View(cliente);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            _context.Add(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            if (id == null)
                return NotFound();

            var cliente = _context.Cliente.SingleOrDefault(a => a.Id == id);

            if (cliente == null)
                return NotFound();

            return View(cliente);

        }

        [HttpPost]
        public IActionResult Edit(int id, Cliente cliente)
        {
            if (id != cliente.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                _context.Update(cliente);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        public IActionResult Delete(int id)
        {
            if (id == null)
                return NotFound();

            var cliente = _context.Cliente.SingleOrDefault(a => a.Id == id);

            if (cliente == null)
                return NotFound();

            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            var cliente = _context.Cliente.SingleOrDefault(a => a.Id == id);

            if (cliente == null)
                return NotFound();

            _context.Remove(cliente);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            if (id == null)
                return NotFound();

            var cliente = _context.Cliente.SingleOrDefault(a => a.Id == id);

            if (cliente == null)
                return NotFound();

            return View(cliente);
        }

       

    }
}
