using System;
namespace starlight_stalkers_rare.Models;

public class Comment
{
    public int Id { get; set; }
    public int AuthorId { get; set; }
    public int PostId { get; set; }
    public string Content { get; set; }
}
