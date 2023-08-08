using System;
namespace starlight_stalkers_rare.Models;

public class Post
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int CategoryId { get; set; }
    public string Title { get; set; }
    public DateTime PublicationDate { get; set; }
    public string Content { get; set; }
    public List<Comment> Comments { get; set; }
    public List<PostTag> PostTags { get; set; }
    public List<Category> Categories { get; set; }
}
