using ayniyatv1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ayniyatv1.Data.Services
{
    public class UrunService : IUrunService
    {
        private readonly AppDbContext _context;
        public UrunService(AppDbContext context)
        {
            _context = context;
        }

        public void Add(Urun urun)
        {
            _context.Urunler.Add(urun);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Urun>> GetAll()
        {
            var result = await _context.Urunler.Include(d=>d.Personel).ToListAsync();
            return result;
        }

        public Urun GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Urun Update(int id, Urun yeniUrun)
        {
            throw new NotImplementedException();
        }
    }
}
