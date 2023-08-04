using ayniyatv1.Models;

namespace ayniyatv1.Data.Services
{
    public interface IUrunService
    {
        Task<IEnumerable<Urun>> GetAllAsync();
        Task<Urun> GetByIdAsync(int id);
        Task AddAsync(Urun urun);
        Task<Urun> UpdateAsync(int id, Urun yeniUrun);
        Task DeleteAsync(int id);
    }
}
