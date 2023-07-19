using ayniyatv1.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ayniyatv1.Models
{
    public class Urun
    {
        [Key]
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string SeriNumarasi { get; set; }
        public string Foto { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public UrunKategori UrunKategori { get; set; }

        public long PersonelId { get; set; }
        [ForeignKey("PersonelId")]
        public virtual Personel Personel { get; set; }  
       
     
    }
}
