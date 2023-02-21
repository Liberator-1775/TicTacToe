using TicTacToe.Application.Common;
using TicTacToe.Domain.Common;

namespace TicTacToe.Infrastructure.Repositories;

public class Repository<TEntity, TPKey> : IRepository<TEntity, TPKey> where TEntity : IEntity<TPKey> where TPKey : IEquatable<TPKey>
{
    
}

public class Repository<TEntity> : IRepository<TEntity> where TEntity : IEntity
{
    
}