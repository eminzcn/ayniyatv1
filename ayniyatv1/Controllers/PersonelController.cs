using ayniyatv1.Data;
using ayniyatv1.Data.Services;
using ayniyatv1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ayniyatv1.Controllers
{
    public class PersonelController : Controller
    {

        private readonly IPersonelService _service;

        public PersonelController(IPersonelService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var tumPersoneller = await _service.GetAllAsync();
            return View(tumPersoneller);
        }
        public async Task<IActionResult> GetirPersonel(string adSoyad)
        {
            if (adSoyad == null || adSoyad.Length < 3)
            {
                return Json(new List<Personel>());
            }
            return Json(await _service.GetAllAsync(d => d.Adi.Contains(adSoyad) || d.Soyadi.Contains(adSoyad)));
        }
        public async Task<IActionResult> GetirPersonelListe()
        {

            return Json(await _service.GetAllAsync());

        }

        // GET : Personel / Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Personel personel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(personel);
            //}

            await _service.AddAsync(personel);
            return RedirectToAction(nameof(Index));
        }

        // GET : Personel Detay
        public async Task<IActionResult> Details(int id)
        {
            var personelDetay = await _service.GetByIdAsync(id);
            if(personelDetay == null)
            {
                return View("Bulunamadi");
            }
            return View(personelDetay);
        }

        // GET : Personel / Update
        public async Task<IActionResult> Edit(int id)
        {
            var personelDetay = await _service.GetByIdAsync(id);
            if (personelDetay == null) return View("Bulunamadi");

            return View(personelDetay);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Personel personel)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View(personel);
            //}

            await _service.UpdateAsync(id, personel);
            return RedirectToAction(nameof(Index));
        }

        // GET : Personel / Delete
        public async Task<IActionResult> Delete(int id)
        {
            var personelDetay = await _service.GetByIdAsync(id);
            if (personelDetay == null) return View("Bulunamadi");

            return View(personelDetay);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personelDetay = await _service.GetByIdAsync(id);
            if (personelDetay == null) return View("Bulunamadi");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
