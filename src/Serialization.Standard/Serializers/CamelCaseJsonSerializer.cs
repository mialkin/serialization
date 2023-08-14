using System.Text.Json;
using Serialization.Standard.Serializers.Interfaces;

namespace Serialization.Standard.Serializers;

public class CamelCaseJsonSerializer : ICamelCaseJsonSerializer
{
    private readonly JsonSerializerOptions _options;

    public CamelCaseJsonSerializer() =>
        _options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

    public string Serialize(object input) => JsonSerializer.Serialize(input, _options);
    public T? Deserialize<T>(string input) => JsonSerializer.Deserialize<T>(input, _options);
}