using ayniyatv1.Data;
using ayniyatv1.Data.Services;
using ayniyatv1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ayniyatv1.Controllers
{
    public class UrunController : Controller
    {

        private readonly IUrunService _service;

        public UrunController(IUrunService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var tumUrunler = await _service.GetAll();
            return View(tumUrunler);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Marka, Model, SeriNumarasi, Foto, CreateDate, UpdateDate, UrunKategori, PersonelId")] Urun urun)
        {
            if (!ModelState.IsValid)
            {
                return View(urun);
            }

            _service.Add(urun);
            return RedirectToAction(nameof(Index));
        }
    }
}