using ayniyatv1.Models;

namespace ayniyatv1.Data
{
    public class AppDbInitializer
    {
        private readonly AppDbContext appDbContext;
        public AppDbInitializer(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public void Seed()
        {

            // Personel
            if (!appDbContext.Personeller.Any())
            {
                var personeller = new List<Personel>()
                {
                    new Personel()
                    {
                        Adi = "Uğur",
                        Soyadi = "Uğur",
                        Birimi = "Uğur",
                        Gorevi = "Uğur",
                        Telefon = "Uğur",
                        Dahili = 45678,
                    },
                    new Personel()
                    {
                        Adi = "Uğur",
                        Soyadi = "Uğur",
                        Birimi = "Uğur",
                        Gorevi = "Uğur",
                        Telefon = "Uğur",
                        Dahili = 45678,
                    },
                    new Personel()
                    {
                        Adi = "Uğur",
                        Soyadi = "Uğur",
                        Birimi = "Uğur",
                        Gorevi = "Uğur",
                        Telefon = "Uğur",
                        Dahili = 45678,
                    }
                };
                appDbContext.Personeller.AddRange(personeller);
                appDbContext.SaveChanges();
            }

            // Urunler
            if (!appDbContext.Urunler.Any())
            {
                var urunler = new List<Urun>()
                {
                    new Urun()
                        {
                            Marka = "Tefal",
                            Model ="EV230",
                            SeriNumarasi = "789451314E",
                            Foto = "",
                            CreateDate = DateTime.Now.AddDays(-50),
                            UpdateDate = DateTime.Now.AddDays(10),
                            UrunKategori = UrunKategori.Dizustu,
                            PersonelId = 1
                        },
                    new Urun()
                        {
                            Marka = "Tefal",
                            Model ="EV230",
                            SeriNumarasi = "789451314E",
                            Foto = "",
                            CreateDate = DateTime.Now.AddDays(-50),
                            UpdateDate = DateTime.Now.AddDays(10),
                            UrunKategori = UrunKategori.Dizustu,
                            PersonelId = 1
                        },
                    new Urun()
                        {
                            Marka = "Tefal",
                            Model ="EV230",
                            SeriNumarasi = "789451314E",
                            Foto = "",
                            CreateDate = DateTime.Now.AddDays(-50),
                            UpdateDate = DateTime.Now.AddDays(10),
                            UrunKategori = UrunKategori.Dizustu,
                            PersonelId = 1
                        },

                };
                appDbContext.Urunler.AddRange(urunler);
                appDbContext.SaveChanges();
            }


        }

    }
}
