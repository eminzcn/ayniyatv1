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

        public async Task AddAsync(Urun urun)
        {
            await _context.Urunler.AddAsync(urun);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Urun>> GetAllAsync()
        {
            var result = await _context.Urunler.Include(d=>d.Personel).ToListAsync();
            return result;
        }

        public async Task<Urun> GetByIdAsync(int id)
        {
            var result = await _context.Urunler.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Urun Update(int id, Urun yeniUrun)
        {
            throw new NotImplementedException();
        }
    }
}
