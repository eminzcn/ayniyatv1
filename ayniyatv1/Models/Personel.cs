using System.ComponentModel.DataAnnotations;

namespace ayniyatv1.Models
{
    public class Personel
    {
        [Key]
        public long Id { get; set; }
        public string Adi { get; set; }

        public string Soyadi { get; set; }
        public string Birimi { get; set; }
        public string Gorevi { get; set; }
        public string Telefon { get; set;}
        public int Dahili { get; set; }
        public string Foto { get; set; }
    }
}
