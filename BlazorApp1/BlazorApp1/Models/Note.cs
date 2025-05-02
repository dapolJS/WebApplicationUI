using System.Text.Json.Serialization;

namespace BlazorApp1.Models;

public class Note
{
    public int Id { get; init; }
    public int? NotebookId { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public bool? Done { get; set; }
    [JsonIgnore]
    public Notebook? Notebook { get; init; }
    public DateTime Date { get; set; }


    public Note()
    {
        NotebookId = 0;
    }
}
