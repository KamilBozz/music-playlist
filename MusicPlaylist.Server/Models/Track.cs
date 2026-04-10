using System.Text.Json.Serialization;

namespace MusicPlaylist.Server.Models;

public class Track
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Artist { get; set; }

    // navigation property
    public int PlaylistId { get; set; }
    [JsonIgnore]
    public Playlist Playlist { get; set; }
}