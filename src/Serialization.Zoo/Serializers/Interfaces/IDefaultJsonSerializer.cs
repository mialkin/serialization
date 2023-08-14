namespace Serialization.Zoo.Serializers.Interfaces;

public interface IDefaultJsonSerializer
{
    string Serialize(object input);
    T? Deserialize<T>(string input);
}