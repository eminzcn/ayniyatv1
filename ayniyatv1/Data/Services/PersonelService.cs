using ayniyatv1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq;

namespace ayniyatv1.Data.Services
{
    public class PersonelService : IPersonelService
    {
        private readonly AppDbContext _context;
        public PersonelService(AppDbContext context) {  _context = context; }
        public async Task AddAsync(Personel personel)
        {
            await _context.Personeller.AddAsync(personel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await _context.Personeller.FirstOrDefaultAsync(n => n.Id == id);
            _context.Personeller.Remove(result);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Personel>> GetAllAsync(Func<Personel, bool > Predications = null)
        {
            if (Predications == null) 
            return await _context.Personeller.ToListAsync();
            return await _context.Personeller.Where(Predications).AsQueryable().ToListAsync();
        }

        public async Task<Personel> GetByIdAsync(int id)
        {
            var result = await _context.Personeller.Include(d => d.Urunler).FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task<Personel> UpdateAsync(int id, Personel yeniPersonel)
        {
            _context.Update(yeniPersonel);
            await _context.SaveChangesAsync();
            return yeniPersonel;
        }
    }
}
