using System.Text.Json.Serialization;

namespace BlazorApp1.Models;

public class Note
{
    public int Id { get; init; }
    public string Content { get; set; } = "";
    public bool? Done { get; set; }
    public DateTime Date { get; init; }

}
