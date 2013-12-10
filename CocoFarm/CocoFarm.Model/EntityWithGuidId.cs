using System;

namespace CocoFarm.Model
{
    public abstract class EntityWithGuidId: IEntityWithId<Guid>
    {
        public Guid Id { get; set; }
    }
}
