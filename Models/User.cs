using System;
namespace starlight_stalkers_rare.Models;

public class User
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Bio { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public DateTime CreatedOn { get; set; }
    public bool Active { get; set; }

    public List<Post> Posts { get; set; }
}

