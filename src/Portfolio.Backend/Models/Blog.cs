namespace Portfolio.Backend.Models;

public class Blog
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string Content { get; set; }
    public string Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public int NumberView { get; set; }
    public int LikeNumber { get; set; }
}