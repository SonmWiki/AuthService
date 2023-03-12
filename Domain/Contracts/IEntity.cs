namespace Domain.Contracts;

public interface IEntity{}

public interface IEntity<TId>
{
    public TId Id { get; set; }
}