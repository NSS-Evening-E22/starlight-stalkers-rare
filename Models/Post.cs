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
    //public List<Comments> Comments { get; set; }
    //public List<PostTags> PostTags { get; set; }
    //public List<Categories> Categories { get; set; }
}
