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
        [Required(ErrorMessage = "Lütfen Marka Bilgisi Giriniz...")]
        public string Marka { get; set; }
        [Display(Name = "MODEL")]
        [Required(ErrorMessage = "Lütfen Model Bilgisi Giriniz...")]
        public string Model { get; set; }
        [Display(Name = "SERİ NO")]
        [Required(ErrorMessage = "Lütfen Seri Numarası Bilgisi Giriniz...")]
        public string SeriNumarasi { get; set; }
        [Display(Name = "FOTOĞRAF")]
        public string? Foto { get; set; }
        public DateTime? CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
      
        [Display(Name = "ÜRÜN KATEGORİSİ")]
        [Required(ErrorMessage = "Lütfen Ürün Kategorisi Bilgisi Seçiniz...")]
        public UrunKategori UrunKategori { get; set; }
        [Display(Name = "ZİMMET")]
     
        public Nullable<long> PersonelId { get; set; }
        [ForeignKey("PersonelId")] 
        public virtual Personel? Personel { get; set; }  
       
     
    }
}
