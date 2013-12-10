namespace CocoFarm.Model
{
    public class Product : EntityWithGuidId
    {
        public string Denumire { get; set; }
        public string Cod { get; set; }
        public string Descriere { get; set; }

        public decimal? Price { get; set; }
    }
}