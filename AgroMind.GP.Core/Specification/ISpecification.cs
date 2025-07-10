using System;
using System.Linq.Expressions;

namespace AgroMind.GP.Core.Specification
{
    public interface ISpecification<TEntity, TKey> where TEntity : AgroMind.GP.Core.Entities.BaseEntity<TKey>
    {
        Expression<Func<TEntity, object>>? OrderBy { get; }
        Expression<Func<TEntity, object>>? OrderByDescending { get; }
        // Add other members as needed for your specifications
    }
}
