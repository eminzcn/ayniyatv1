using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ayniyatv1.Data
{
    public enum UrunKategori
    {
        [Display(Name = "Dizüstü")]
        Dizustu = 1,
        [Display(Name = "Bilgisayar Kasası")]
        Kasa,
        [Display(Name = "Monitör")]
        Monitor,
        Fare,
        [Display(Name = "Klavye")]
        Klavye,
        Kablo,
        [Display(Name = "Çanta")]
        Canta,
        Sandalye,
        [Display(Name = "Fotoğraf Makinası")]
        FotografMakinasi,
        [Display(Name = "Yazıcı")]
        Yazici,
        [Display(Name = "Tarayıcı")]
        Tarayici,
        Televizyon,
        [Display(Name = "Uydu Alıcısı")]
        UyduAlicisi,
        [Display(Name = "Diğer")]
        Diger
    }
}
