namespace BCApiClient.Rest.Client.Common
{
    public class EntityNotFound : System.Exception
    {
            public EntityNotFound() { }
            public EntityNotFound(string message) : base(message) { }
            public EntityNotFound(string message, System.Exception inner) : base(message, inner) { }
            protected EntityNotFound(
              System.Runtime.Serialization.SerializationInfo info,
              System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
        
    }
}
