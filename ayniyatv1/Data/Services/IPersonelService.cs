using ayniyatv1.Models;

namespace ayniyatv1.Data.Services
{
    public interface IPersonelService
    {
        Task<IEnumerable<Personel>> GetAllAsync(Func<Personel, bool> Predications = null);
        Task<Personel> GetByIdAsync(int id);
        Task AddAsync(Personel personel);
        Task<Personel> UpdateAsync(int id, Personel yeniPersonel);
        Task DeleteAsync(int id);
    }
}
