namespace starlight_stalkers_rare.Models;

public class PostReaction
{
    public int Id { get; set; }
    public int ReactionId { get; set; }
    public int UserId { get; set; }
    public int PostId { get; set; }

}
