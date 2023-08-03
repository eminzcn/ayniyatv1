using ayniyatv1.Data;
using ayniyatv1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ayniyatv1.Controllers
{
    public class PersonelController : Controller
    {

        private readonly AppDbContext _context;

        public PersonelController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Personeller.ToList();
            return View(data);
        }
        public async Task<IActionResult> GetirPersonel(string adSoyad)
        {
            if (adSoyad == null || adSoyad.Length <3)
            {
                return Json(new List<Personel>());
            }
            return Json(await _context.Personeller.Where(d => d.Adi.Contains(adSoyad) || d.Soyadi.Contains(adSoyad)).ToListAsync());
        }
        public async Task<IActionResult> GetirPersonelListe()
        {

            return Json(await _context.Personeller.ToListAsync());

        }

    }
}
