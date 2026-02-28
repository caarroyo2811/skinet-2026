using skinet.Models.Interface;
using System.Linq.Expressions;

using System.Reflection.Metadata;

namespace skinet.Models.Specifications
{
    public class BaseSpecification<T>(Expression<Func<T, bool>>? criteria) : ISpecification<T>
    {
        protected BaseSpecification() : this(null) { }
        public Expression<Func<T, bool>>? Criteria => criteria;
        public Expression<Func<T, object>>? OderBy {get; private set;} 
        public Expression<Func<T, object>>? OderByDescending { get; private set;}

        public bool IsDistinct { get; private set; }

        protected void AddOrderBy(Expression<Func<T, object>> orderByExpression)
        {
            OderBy = orderByExpression;
        }
        protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression)
        {
            OderByDescending = orderByDescExpression;
        }
        protected void ApplyDistinct()
        {
            IsDistinct = true;
        }
    }
    public class BaseSpecification<T, TResult>(Expression<Func<T, bool>> criteria) : BaseSpecification<T>(criteria), ISpecification<T, TResult>
    {
        protected BaseSpecification() : this(null!) { }
        public Expression<Func<T, TResult>>? Select { get; private set; }
        protected void AddSelect(Expression<Func<T, TResult>> selectExpression)
        {
            Select = selectExpression;
        }
    }
}
