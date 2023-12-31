﻿using ayniyatv1.Data;
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
            var tumUrunler = await _service.GetAllAsync();
            return View(tumUrunler);
        }

        // Get: Urun/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Urun urun)
        {
            if (!ModelState.IsValid)
            {
                return View(urun);
            }

            await _service.AddAsync(urun);
            return RedirectToAction(nameof(Index));
        }

        // Get: Ürün Detay
        public async Task<IActionResult> Details(int id)
        {
            var urunDetay = await _service.GetByIdAsync(id);

            if (urunDetay == null) return View("Bulunamadi");
            return View(urunDetay);
        }

        // Get: Urun/Update
        public async Task<IActionResult> Edit(int id)
        {
            var urunDetay = await _service.GetByIdAsync(id);
            if (urunDetay == null) return View("Bulunamadi");

            return View(urunDetay);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Urun urun)
        {
            if (!ModelState.IsValid)
            {
                return View(urun);
            }

            await _service.UpdateAsync(id, urun);
            return RedirectToAction(nameof(Index));
        }

        // Get: Urun/Delete
        public async Task<IActionResult> Delete(int id)
        {
            var urunDetay = await _service.GetByIdAsync(id);
            if (urunDetay == null) return View("Bulunamadi");

            return View(urunDetay);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var urunDetay = await _service.GetByIdAsync(id);
            if (urunDetay == null) return View("Bulunamadi");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}