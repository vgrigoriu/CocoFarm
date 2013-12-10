namespace CocoFarm.Model
{
    public class Produs : EntityWithGuidId
    {
        public string Denumire { get; set; }
        public string Cod { get; set; }
        public string Descriere { get; set; }
    }
}