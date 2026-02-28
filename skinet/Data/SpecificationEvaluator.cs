using skinet.Models.Entities;
using skinet.Models.Interface;

namespace skinet.Data
{
    public class SpecificationEvaluator<T> where T : BaseEntity
    {
        public static IQueryable<T> GetQuery(IQueryable<T> query, ISpecification<T> spec)
        {          
            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria); // x => x.Brand == brand
            }

            if (spec.OderBy != null)
            {
                query = query.OrderBy(spec.OderBy);
            }

             if (spec.OderByDescending != null)
             {
                 query = query.OrderByDescending(spec.OderByDescending);
             }
             if (spec.IsDistinct)
             {
                 query = query.Distinct();
             }

            return query;
        }

        public static IQueryable<TResult> GetQuery<TSpect, TResult>(IQueryable<T> query, ISpecification<T, TResult> spec)
        {
            if (spec.Criteria != null)
            {
                query = query.Where(spec.Criteria); // x => x.Brand == brand
            }

            if (spec.OderBy != null)
            {
                query = query.OrderBy(spec.OderBy);
            }

            if (spec.OderByDescending != null)
            {
                query = query.OrderByDescending(spec.OderByDescending);
            }
             var selectQuery = query as IQueryable<TResult>;

            if (spec.Select != null)
            {
                selectQuery = query.Select(spec.Select);
            }

            if (spec.IsDistinct)
            {
                selectQuery = selectQuery?.Distinct();
            }

            return selectQuery ?? query.Cast<TResult>();
        }
    }
}
