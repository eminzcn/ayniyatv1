using ayniyatv1.Models;

namespace ayniyatv1.Data.Services
{
    public interface IUrunService
    {
        Task<IEnumerable<Urun>> GetAll();
        Urun GetById(int id);
        void Add(Urun urun);
        Urun Update(int id, Urun yeniUrun);
        void Delete(int id);
    }
}
