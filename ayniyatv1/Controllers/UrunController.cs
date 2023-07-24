using ayniyatv1.Data;
using Microsoft.AspNetCore.Mvc;

namespace ayniyatv1.Controllers
{
    public class UrunController : Controller
    {

        private readonly AppDbContext _context;

        public UrunController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var data = _context.Urunler.ToList();
            return View();
        }
    }
}