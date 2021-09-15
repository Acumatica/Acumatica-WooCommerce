using PX.Commerce.WooCommerce.API.REST.Client.Common;
using PX.Commerce.WooCommerce.API.REST.Domain.Entities.Order;
using PX.Commerce.WooCommerce.API.REST.Filters;
using PX.Commerce.WooCommerce.API.REST.Interfaces;
using System.Collections.Generic;

namespace PX.Commerce.WooCommerce.API.REST.Client.DataRepository
{
    public class OrderNotesDataProvider : RestDataProvider, IChildRestDataProvider<NoteData>
    {
        protected override string GetListUrl { get; } = "/orders/{parent_id}/notes";
        protected override string GetSingleUrl { get; } = "/orders/{parent_id}/notes/{id}";

        public OrderNotesDataProvider(IWooRestClient restClient) : base()
        {
            _restClient = restClient;
        }

        #region  IParentRestDataProvider  

        public List<NoteData> Get(IFilter filter = null)
        {
            return base.Get<NoteData, List<NoteData>>(filter);
        }

        public IEnumerable<NoteData> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public NoteData GetByID(string id, string parentId)
        {
            var segments = MakeUrlSegments(id);
            return GetByID<NoteData>(segments);
        }

        public bool Delete(NoteData productRefundData, int id)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            var segments = MakeUrlSegments(id.ToString());
            return base.Delete(segments);
        }

        public NoteData Create(NoteData note)
        {
            throw new System.NotImplementedException();
        }

        public NoteData Update(NoteData category, int id)
        {
            throw new System.NotImplementedException();
        }

        public List<NoteData> GetByParentId(string parentId)
        {
            var segments = MakeParentUrlSegments(parentId);
            return base.Get<NoteData, List<NoteData>>(null, segments);
        }

        public NoteData Create(NoteData entity, string parentId)
        {
            var segments = MakeParentUrlSegments(parentId.ToString());
            return base.Create<NoteData>(entity, segments);
        }

        public NoteData Update(NoteData entity, string id, string parentId)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(string id, string parentId)
        {
            throw new System.NotImplementedException();
        }
        #endregion

    }
}
