using System.ComponentModel.DataAnnotations;

namespace MVCDemoS.Models
{
    public class SiteInfo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string GlobalCertificate { get; set; }
        [Required]
        public string Address { get; set; }
        public DateTimeOffset InsertedDate { get; set; } = DateTimeOffset.Now;

    }
}
