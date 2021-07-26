using System;
using RestSharp;

namespace ACSC.Tests.ShopifyRest.Interfaces
{
    public interface IFilter
    {
        void AddFilter(IRestRequest request);
    }

	public interface IFilterWithIDs : IFilter
	{
		string IDs { get; set; }
	}

	public interface IFilterWithSinceID : IFilter
	{
		string SinceID { get; set; }
	}

	public interface IFilterWithLimit: IFilter
	{
		int? Limit { get; set; }
	}

	public interface IFilterWithFields : IFilter
	{
		string Fields { get; set; }
	}

	public interface IFilterWithDateTime : IFilter
	{
		DateTime? CreatedAtMin { get; set; }
		DateTime? CreatedAtMax { get; set; }
		DateTime? UpdatedAtMin { get; set; }
		DateTime? UpdatedAtMax { get; set; }
	}
}
