using System.ComponentModel.DataAnnotations;

namespace RequestMail.Models
{
    public class Contact
    {
        
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
       
        public string Lokasyon { get; set; }
        
        public string Direktor { get; set; }
        
        public string Sirket { get; set; }
        
        public string Talep { get; set; }
    }
}
