namespace BCApiClient.Rest.Interfaces
{
    public interface IRestDataReader<out T> where T : class
    {
        T Get();
    }
}