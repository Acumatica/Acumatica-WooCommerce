namespace PX.Commerce.WooCommerce.API.REST.Interfaces
{
    public interface IRestDataReader<out T> where T : class
    {
        T Get();
    }
}