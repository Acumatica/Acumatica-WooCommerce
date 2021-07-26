using System.Collections.Generic;

namespace BCApiClient.Rest.Interfaces
{
    public interface IChildReadOnlyRestDataProvider<T> where T : class
    {
        int Count(int parentId);
        List<T> Get(int id);
        T GetByID(int id, int parentId);
    }

    public interface IChildRestDataProvider<T> : IChildReadOnlyRestDataProvider<T> where T : class
    {
        T Create(T entity, int parentId);
        T Update(T entity, int id, int parentId);
        bool Delete(int parentId);
    }

    public interface ISubChildRestDataProvider<T>  where T : class
    {
        int Count(string parentId, string subId);
        List<T> Get(string parentId, string subId);
        T GetByID(string parentId, string subId, string id);

        T Create(T entity, string parentId, string subId);
        T Update(T entity, string parentId, string subId, string id);
        bool Delete(string parentId, string subId, string id);
    }
}