using Newtonsoft.Json;

namespace Serialization.Newtonsoft.Serializers;

public class NewtonsoftJsonSerializer : INewtonsoftJsonSerializer
{
    public string Serialize(object input) => JsonConvert.SerializeObject(input);
    public T? Deserialize<T>(string value) => JsonConvert.DeserializeObject<T>(value);
}