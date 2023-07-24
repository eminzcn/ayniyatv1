using ayniyatv1.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ayniyatv1.Models
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "MARKA")]
        public string Marka { get; set; }
        [Display(Name = "MODEL")]
        public string Model { get; set; }
        [Display(Name = "SERİ NO")]
        public string SeriNumarasi { get; set; }
        [Display(Name = "FOTOĞRAF")]
        public string? Foto { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Display(Name = "ÜRÜN KATEGORİSİ")]
        public UrunKategori UrunKategori { get; set; }
        [Display(Name = "ZİMMET")]
        public long PersonelId { get; set; }
        [ForeignKey("PersonelId")]
        public virtual Personel Personel { get; set; }  
       
     
    }
}
