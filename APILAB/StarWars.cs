using System.Text.Json.Serialization;
public class StarWars
{
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("height")]
    public string Height { get; set; }
    [JsonPropertyName("mass")]
    public string Mass { get; set; }
    [JsonPropertyName("population")]
    public string Population { get; set; }
    [JsonPropertyName("lenght")]
    public string Length { get; set; }
    [JsonPropertyName("title")]
    public string Title { get; set; }
    [JsonPropertyName("release_date")]
    public string ReleaseDate { get; set; }
}
