using TicTacToe.Domain.Common;

namespace TicTacToe.Application.Common;

public interface IRepository<TEntity, TPKey> where TEntity : IEntity<TPKey> where TPKey : IEquatable<TPKey>
{
}

public interface IRepository<TEntity> where TEntity : IEntity
{
}