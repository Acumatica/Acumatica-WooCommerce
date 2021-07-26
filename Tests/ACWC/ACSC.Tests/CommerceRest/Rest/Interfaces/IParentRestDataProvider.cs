using System.Collections.Generic;
using BCApiClient.Rest.Domain.Entities.Common;
using BCApiClient.Rest.Filters;

namespace BCApiClient.Rest.Interfaces
{
    public interface IParentRestDataProvider<T>  where T : class
    {   
        T Create(T entity);
        T Update(T entity, int id);
        bool Delete(int id);
        List<T> Get(IFilter filter = null) ;
        List<T> GetAll(IFilter filter = null);
        T GetByID(int id);
        T GetByName(string name);
        ItemCount Count();
        ItemCount Count(IFilter filter);
    }
}