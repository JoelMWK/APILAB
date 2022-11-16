using System.Text.Json.Serialization;
public class Pokemon
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("weight")]
    public int Weight { get; set; }
    [JsonPropertyName("is_default")]
    public bool IsDefault { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("height")]
    public int Height { get; set; }
}
