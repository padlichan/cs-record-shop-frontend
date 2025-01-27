using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace cs_record_shop_frontend.Client.Models;

public class AlbumInputDto
{
    public AlbumInputDto(string title, int year, string artistName, string description = "")
    {
        Title = title;
        Year = year;
        ArtistName = artistName;
        Description = description;
    }

    [Required]
    [JsonPropertyName("title")]
    public string Title { get; set; }

    [Required]
    [JsonPropertyName("year")]
    public int Year { get; set; }

    [Required]
    [JsonPropertyName("artistName")]
    public string ArtistName { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }
}
