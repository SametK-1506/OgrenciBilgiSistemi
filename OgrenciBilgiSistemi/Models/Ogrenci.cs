using System.ComponentModel.DataAnnotations;

namespace OgrenciBilgiSistemi.Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı zorunludur.")]
        [Display(Name = "Öğrenci Adı")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "Soyad alanı zorunludur.")]
        [Display(Name = "Öğrenci Soyadı")]
        public string Soyad { get; set; }

        [Required]
        [Display(Name = "Okul Numarası")]
        public string OkulNo { get; set; }

        [Display(Name = "Sınıfı")]
        public string Sinif { get; set; }

        [Display(Name = "Bölümü")]
        public string Bolum { get; set; }

        [Display(Name = "Kayıt Tarihi")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}