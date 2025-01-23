namespace cs_record_shop_frontend.Models;
public class Album
{
    public Album(int id, string title, string description, int year, string artistName)
    {
        Id = id;
        Title = title;
        Description = description;
        Year = year;
        ArtistName = artistName;
    }

    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int Year { get; set; }
    public string ArtistName { get; set; }
}
