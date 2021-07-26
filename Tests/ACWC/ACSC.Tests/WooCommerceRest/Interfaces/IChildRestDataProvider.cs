using System.Collections.Generic;

namespace ACSC.Tests.ShopifyRest.Interfaces
{
    public interface IChildReadOnlyRestDataProvider<T> where T : class
    {
		int Count(string parentId);
		List<T> GetCurrentList(string parentId, out string previousList, out string nextList, IFilter filter = null);
		List<T> GetAll(string parentId, IFilter filter = null);
		List<T> GetAllWithoutParent(IFilter filter = null);
		T GetByID(string parentId, string id);
	}

    public interface IChildRestDataProvider<T> : IChildReadOnlyRestDataProvider<T> where T : class
    {
		T Create(T entity, string parentId);
		T Update(T entity, string parentId, string id);
		bool Delete(string parentId, string id);
	}

}