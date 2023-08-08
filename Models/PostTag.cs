using System;
namespace starlight_stalkers_rare.Models;

public class PostTag
{
    public int Id { get; set; }
    public int PostId { get; set; }
    public int TagId { get; set; }
    //public List<Tags> Tags { get; set; }
}
