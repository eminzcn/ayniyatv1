using ayniyatv1.Data;
using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
