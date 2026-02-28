using System.Linq.Expressions;


namespace skinet.Models.Interface
{
    public interface ISpecification<T>
    {
        Expression<Func<T, bool>>? Criteria { get; }
        Expression<Func<T, object>>? OderBy { get; }
        Expression<Func<T, object>>? OderByDescending { get; }
        bool IsDistinct { get; }

    }

    public interface ISpecification<T, TResult> : ISpecification<T>
    {
        Expression<Func<T, TResult>>? Select { get; }
    }
}
