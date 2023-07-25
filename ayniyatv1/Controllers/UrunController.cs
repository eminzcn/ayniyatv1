using ayniyatv1.Data;
using ayniyatv1.Data.Services;
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
    }
}