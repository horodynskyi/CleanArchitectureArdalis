using Microsoft.EntityFrameworkCore;

namespace Parking.Core.Common;

public static class QueryableExtensions
{
    public static List<T> ToPagedList<T>(this IQueryable<T> entities,int pageSize, int pageNumber)
    {
        return entities.Take(((pageNumber - 1) * pageSize)..(pageSize * pageNumber)).ToList();
    }
    public async static Task<List<T>> ToPagedListAsync<T>(this IQueryable<T> entities,int pageSize, int pageNumber,CancellationToken cancellationToken)
    {
        var list = new List<T>();
        await foreach (var element in entities.AsAsyncEnumerable().WithCancellation(cancellationToken))
        {
            list.Add(element);
        }

        return list.Take(((pageNumber-1)*pageSize)..(pageSize*pageNumber)).ToList();
    }
}