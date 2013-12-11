using System.ComponentModel.DataAnnotations;

namespace CocoFarm.Model
{
    public class Product : EntityWithGuidId
    {
        [Required]
        public string Denumire { get; set; }
        [Required]
        public string Cod { get; set; }
        public string Descriere { get; set; }

        public decimal? Price { get; set; }
    }
}