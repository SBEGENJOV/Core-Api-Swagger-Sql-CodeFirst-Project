using System.ComponentModel.DataAnnotations;

namespace CoreApiSwaggerProject.Models
{
    public class Bayi
    {
        [Key]
        public int BayiId { get; set; }
        public string BayiAdi { get; set; }
        public string Sube { get; set; }
    }
}
