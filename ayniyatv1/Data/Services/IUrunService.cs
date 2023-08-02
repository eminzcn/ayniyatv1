using ayniyatv1.Models;

namespace ayniyatv1.Data.Services
{
    public interface IUrunService
    {
        Task<IEnumerable<Urun>> GetAllAsync();
        Task<Urun> GetByIdAsync(int id);
        Task AddAsync(Urun urun);
        Urun Update(int id, Urun yeniUrun);
        void Delete(int id);
    }
}
