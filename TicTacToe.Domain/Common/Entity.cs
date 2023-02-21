namespace TicTacToe.Domain.Common;

public class Entity : Entity<int>
{
}

public class Entity<T> : IEntity<T> where T : IEquatable<T>
{
    public T Id { get; set; } = default!;
}