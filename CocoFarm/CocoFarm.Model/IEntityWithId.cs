namespace CocoFarm.Model
{
    public interface IEntityWithId<T>
    {
        T Id { get; set; }
    }
}
