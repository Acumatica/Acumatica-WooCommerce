using CommonServiceLocator;
using Newtonsoft.Json;
using PX.Commerce.BigCommerce.API.REST;
using PX.Commerce.Core;
using PX.Commerce.Objects;
using PX.Commerce.WooCommerce.API.REST.Client;
using PX.Commerce.WooCommerce.Sync.Processors;
using PX.Commerce.WooCommerce.WC.DAC;
using PX.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PX.Commerce.WooCommerce
{
    #region WooCommerceConnectorFactory
    public class WooCommerceConnectorFactory : BaseConnectorFactory<WCConnector>, IConnectorFactory
    {
        public override string Description => WCConnector.NAME;
        public override bool Enabled => true;

        public override string Type => WCConnector.TYPE;

        public WooCommerceConnectorFactory(IEnumerable<IProcessorsFactory> processors)
            : base(processors)
        {
        }

        public IConnectorDescriptor GetDescriptor()
        {
            return new WooCommercesConnectorDescriptor(_processors.Values.ToList());
        }
    }
    #endregion

    #region WooCommerceProcessorsFactory
    public class WooCommerceProcessorsFactory : IProcessorsFactory
    {
        public string ConnectorType => WCConnector.TYPE;

        public IEnumerable<KeyValuePair<Type, int>> GetProcessorTypes()
        {
            yield return new KeyValuePair<Type, int>(typeof(WCCustomerProcessor), 20);
            yield return new KeyValuePair<Type, int>(typeof(WCStockItemProcessor), 50);
            yield return new KeyValuePair<Type, int>(typeof(WCCategoryProcessor), 40);
            yield return new KeyValuePair<Type, int>(typeof(WCSalesOrderProcessor), 120);
            yield return new KeyValuePair<Type, int>(typeof(WCPaymentProcessor), 130);
            yield return new KeyValuePair<Type, int>(typeof(WCShipmentProcessor), 140);
            //yield return new KeyValuePair<Type, int>(typeof(WCRefundsProcessor), 150);
        }
    }
    #endregion

    public class WCConnector : BCConnectorBase<WCConnector>, IConnector
    {
        #region IConnector
        public const string TYPE = "WCC";
        public const string NAME = "WooCommerce";

        public class WCConnectorType : Data.BQL.BqlString.Constant<WCConnectorType>
        {
            public WCConnectorType() : base(TYPE) { }
        }

        public override string ConnectorType { get => TYPE; }
        public override string ConnectorName { get => NAME; }

        public virtual IEnumerable<TInfo> GetExternalInfo<TInfo>(string infoType, int? bindingID)
            where TInfo : class
        {
            if (string.IsNullOrEmpty(infoType) || bindingID == null) return null;
            BCBindingWooCommerce binding = BCBindingWooCommerce.PK.Find(this, bindingID);
            if (binding == null) return null;

            try
            {
                List<TInfo> result = new List<TInfo>();
                //if (infoType == BCObjectsConstants.BCPayment)
                //{
                //    object paymentItem = new PaymentMethods() { Name = BCObjectsConstants.Custom };
                //    result.Add((TInfo)paymentItem);
                //    paymentItem = new PaymentMethods() { Name = BCObjectsConstants.StoreCreditCode };
                //    result.Add((TInfo)paymentItem);
                //    paymentItem = new PaymentMethods() { Name = BCObjectsConstants.GiftCertificateCode };
                //    result.Add((TInfo)paymentItem);
                //    paymentItem = new PaymentMethods() { Name = BCObjectsConstants.PayPal, CreatePaymentfromOrder = true };
                //    result.Add((TInfo)paymentItem);
                //    paymentItem = new PaymentMethods() { Name = BCObjectsConstants.TestPaymentGateway, CreatePaymentfromOrder = true };
                //    result.Add((TInfo)paymentItem);
                //    paymentItem = new PaymentMethods() { Name = BCObjectsConstants.Amazon, CreatePaymentfromOrder = true };
                //    result.Add((TInfo)paymentItem);
                //}
                return result;
            }
            catch (Exception ex)
            {
                LogError(new BCLogTypeScope(typeof(WCConnector)), ex);
            }

            return null;
        }
        #endregion

        #region Navigation
        public void NavigateExtern(ISyncStatus status)
        {
            if (status?.ExternID == null) return;

            EntityInfo info = GetEntities().FirstOrDefault(e => e.EntityType == status.EntityType);
            BCBindingWooCommerce bCBindingBigCommerce = BCBindingWooCommerce.PK.Find(this, status.BindingID);

            if (string.IsNullOrEmpty(bCBindingBigCommerce?.StoreAdminUrl) || string.IsNullOrEmpty(info.URL)) return;

            string[] parts = status.ExternID.Split(new char[] { ';' });
            string url = string.Format(info.URL, parts.Length > 2 ? parts.Take(2).ToArray() : parts);
            string redirectUrl = bCBindingBigCommerce.StoreAdminUrl.TrimEnd('/') + "/" + url;

            throw new PXRedirectToUrlException(redirectUrl, PXBaseRedirectException.WindowMode.New, string.Empty);
        }
        #endregion

        #region Process
        public virtual SyncInfo[] Process(ConnectorOperation operation, int?[] syncIDs = null)
        {
            LogInfo(operation.LogScope(), BCMessages.LogConnectorStarted, NAME);

            EntityInfo info = GetEntities().FirstOrDefault(e => e.EntityType == operation.EntityType);
            using (IProcessor graph = (IProcessor)CreateInstance(info.ProcessorType))
            {
                graph.Initialise(this, operation);
                return graph.Process(syncIDs);
            }
        }

        public DateTime GetSyncTime(ConnectorOperation operation)
        {
            BCBindingWooCommerce binding = BCBindingWooCommerce.PK.Find(this, operation.Binding);
            //Acumatica Time
            PXDatabase.SelectDate(out DateTime dtLocal, out DateTime dtUtc);
            dtLocal = PX.Common.PXTimeZoneInfo.ConvertTimeFromUtc(dtUtc, PX.Common.LocaleInfo.GetTimeZone());


            return dtLocal;
        }
        #endregion

        #region Notifications
        public override void StartWebHook(string baseUrl, BCWebHook hook)
        {
            throw new NotImplementedException();
        }

        public virtual void ProcessHook(IEnumerable<BCExternQueueMessage> messages)
        {
            throw new NotImplementedException();
        }

        public override void StopWebHook(string baseUrl, BCWebHook hook)
        {
            throw new NotImplementedException();
        }
        #endregion

        public static WooRestClient GetRestClient(BCBindingWooCommerce binding)
        {
            return GetRestClient(binding.StoreBaseUrl, binding.StoreXAuthClient, binding.StoreXAuthToken);
        }

        public static WooRestClient GetRestClient(String url, String clientID, String token)
        {
            RestOptions options = new RestOptions
            {
                BaseUri = url,
                XAuthClient = clientID,
                XAuthTocken = token
            };
            JsonSerializer serializer = new JsonSerializer
            {
                MissingMemberHandling = MissingMemberHandling.Ignore,
                NullValueHandling = NullValueHandling.Ignore,
                DefaultValueHandling = DefaultValueHandling.Include,
                DateFormatHandling = DateFormatHandling.IsoDateFormat,
                DateTimeZoneHandling = DateTimeZoneHandling.Unspecified,
                ContractResolver = new Core.REST.GetOnlyContractResolver()
            };
            RestJsonSerializer restSerializer = new RestJsonSerializer(serializer);
            WooRestClient client = new WooRestClient(restSerializer, restSerializer, options,
                ServiceLocator.Current.GetInstance<Serilog.ILogger>());

            return client;
        }

    }

    #region WooCommercesConnectorDescriptor
    public class WooCommercesConnectorDescriptor : IConnectorDescriptor
    {
        protected IList<EntityInfo> _entities;

        public WooCommercesConnectorDescriptor(IList<EntityInfo> entities)
        {
            _entities = entities;
        }

        public virtual Guid? GenerateExternID(BCExternNotification message)
        {
            WebHookMessage jResult = JsonConvert.DeserializeObject<WebHookMessage>(message.Json);

            string scope = jResult.Scope;
            string producer = jResult.Producer;
            string data = jResult.Data;
            string storehash = producer.Substring(producer.LastIndexOf("/") + 1);
            EntityInfo info = _entities.FirstOrDefault(e => e.ExternRealtime.Supported && e.ExternRealtime.WebHookType != null && e.ExternRealtime.WebHooks.Contains(scope));
            Object obj = JsonConvert.DeserializeObject(data, info.ExternRealtime.WebHookType);
            String id = obj?.ToString();

            if (obj == null || id == null) return null;

            Byte[] bytes = new Byte[16];
            BitConverter.GetBytes(WCConnector.TYPE.GetHashCode()).CopyTo(bytes, 0); //Connector
            BitConverter.GetBytes(info.EntityType.GetHashCode()).CopyTo(bytes, 4); //EntityType
            BitConverter.GetBytes(storehash.GetHashCode()).CopyTo(bytes, 8); //Store
            BitConverter.GetBytes(id.GetHashCode()).CopyTo(bytes, 12); //ID

            return new Guid(bytes);
        }

        public virtual Guid? GenerateLocalID(BCLocalNotification message)
        {
            Guid? noteId = message.Fields.First(v => v.Key.EndsWith("NoteID", StringComparison.InvariantCultureIgnoreCase) && v.Value != null).Value.ToGuid();
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(WCConnector.TYPE.GetHashCode()).CopyTo(bytes, 0); //Connector
            BitConverter.GetBytes(message.Entity.GetHashCode()).CopyTo(bytes, 4); //EntityType
            BitConverter.GetBytes(message.Binding.GetHashCode()).CopyTo(bytes, 8); //Store
            BitConverter.GetBytes(noteId.GetHashCode()).CopyTo(bytes, 12); //ID
            return new Guid(bytes);
        }
        public List<Tuple<string, string, string>> GetExternalFields(string type, int? binding, string entity)
        {
            List<Tuple<string, string, string>> fieldsList = new List<Tuple<string, string, string>>();
            if (entity != BCEntitiesAttribute.Customer && entity != BCEntitiesAttribute.Address) return fieldsList;

            return fieldsList;
        }
    }
    #endregion
}
