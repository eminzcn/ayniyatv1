using ayniyatv1.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ayniyatv1.Controllers
{
    public class UrunController : Controller
    {

        private readonly AppDbContext _context;

        public UrunController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var tumUrunler = await _context.Urunler.ToListAsync();
            return View(tumUrunler);
        }
    }
}