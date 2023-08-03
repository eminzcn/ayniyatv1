using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ayniyatv1.Models
{
    public class Personel
    {
        [Key]
        public long Id { get; set; }
        [Display(Name = "PERSONEL ADI")]
        public string Adi { get; set; }
        [Display(Name = "SOYADI")]
        public string Soyadi { get; set; }
        [Display(Name = "BİRİMİ")]
        public string Birimi { get; set; }
        [Display(Name = "GÖREVİ")]
        public string Gorevi { get; set; }
        [Display(Name = "TELEFON")]
        public string Telefon { get; set;}
        [Display(Name = "DAHİLİ")]
        public int Dahili { get; set; }
        [Display(Name = "FOTOĞRAF")]
        public string? Foto { get; set; }

        // İlişkiler
       
        public virtual List<Urun> Urunler { get; set; }
    }
}
