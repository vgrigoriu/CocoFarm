using System.ComponentModel.DataAnnotations;

namespace CocoFarm.Model
{
    public class Product : EntityWithGuidId
    {
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        public string Description { get; set; }

        public decimal? Price { get; set; }
    }
}