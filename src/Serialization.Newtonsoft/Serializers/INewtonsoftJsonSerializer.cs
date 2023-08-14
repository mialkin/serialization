namespace Serialization.Newtonsoft.Serializers;

public interface INewtonsoftJsonSerializer
{
    string Serialize(object input);
    T? Deserialize<T>(string value);
}