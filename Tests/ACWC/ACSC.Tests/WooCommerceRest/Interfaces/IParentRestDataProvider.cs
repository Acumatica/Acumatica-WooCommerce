using System.Collections.Generic;
using ACSC.Tests.ShopifyRest.Domain.Entities.Common;

namespace ACSC.Tests.ShopifyRest.Interfaces
{
    public interface IParentRestDataProvider<T>  
		where T : class 
    {   
        T Create(T entity);
		T Update(T entity, string id);
		bool Delete(string id);

	//	List<T> GetCurrentList(out string previousList, out string nextList, IFilter filter = null) ;
     //   List<T> GetAll(IFilter filter = null);
		T GetByID(string id);
		//List<MetafieldData> GetMetaFieldData(string ownerId);

		ItemCount Count();
        ItemCount Count(IFilter filter);
    }
}