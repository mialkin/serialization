namespace Serialization.Standard.Serializers.Interfaces;

public interface ICamelCaseJsonSerializer
{
    string Serialize(object input);
    T? Deserialize<T>(string input);
}