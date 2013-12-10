namespace CocoFarm.Model
{
    public class Produs : IEntityWithId<int>
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Cod { get; set; }
        public string Descriere { get; set; }
    }
}