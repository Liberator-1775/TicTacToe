namespace TicTacToe.Domain.Common;

public interface IEntity : IEntity<int>
{
}

public interface IEntity<T> where T : IEquatable<T>
{
    public T Id { get; set; }
}