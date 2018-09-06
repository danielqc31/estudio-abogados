namespace Dqc.Domain.Entities
{
    public interface IEntityBase<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }

        bool IsTransient();
    }

    public interface IEntityBase : IEntityBase<int>
    {
    }
}
