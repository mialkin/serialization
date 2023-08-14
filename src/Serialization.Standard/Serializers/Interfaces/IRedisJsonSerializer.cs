namespace Serialization.Standard.Serializers.Interfaces;

public interface IRedisJsonSerializer
{
    string Serialize(object input);
    T? Deserialize<T>(string input);
}