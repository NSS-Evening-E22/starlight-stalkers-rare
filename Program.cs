
using Microsoft.Extensions.Hosting;
using starlight_stalkers_rare.Models;
using System.IO;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//DATA
List<User> users = new List<User>
{
  new User
  {
    Id = 101,
    FirstName = "John",
    LastName = "Doe",
    Email = "john.doe@example.com",
    Bio = "Software Engineer and aspiring artist",
    Username = "johndoe87",
    Password = "p@ssw0rd123",
    CreatedOn = new DateTime(2023-08-01),
    Active = true
  },
  new User
  {
    Id = 102,
    FirstName = "Jane",
    LastName = "Smith",
    Email = "jane.smith@example.com",
    Bio = "Marketing specialist with a passion for travel",
    Username = "janesmith",
    Password = "M@rket1ng!",
    CreatedOn = new DateTime(2023-06-25),
    Active = true
  },
  new User
  {
    Id = 103,
    FirstName = "Michael",
    LastName = "Johnson",
    Email = "michael.johnson@example.com",
    Bio = "Fitness enthusiast and personal trainer",
    Username = "mikefit",
    Password = "Strong@Pass123",
    CreatedOn = new DateTime(2023-02-15),
    Active = true
  },
  new User
  {
    Id = 104,
    FirstName = "Emily",
    LastName = "Brown",
    Email = "emily.brown@example.com",
    Bio = "Book lover and aspiring writer",
    Username = "emwrites",
    Password = "BookWorm99!",
    CreatedOn = new DateTime(2023-03-05),
    Active = true
  },
  new User
  {
    Id = 105,
    FirstName = "David",
    LastName = "Lee",
    Email = "david.lee@example.com",
    Bio = "Tech geek and gamer",
    Username = "davidgamer",
    Password = "G@mingF0rever",
    CreatedOn = new DateTime(2023-08-05),
    Active = true
  }
};

List<Post> posts = new List<Post>
{
    new Post
    {
        Id = 201,
        UserId = 101,
        CategoryId = 1,
        Title = "Introduction to Programming",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "In this article, we will introduce the basics of programming."
    },
    new Post
    {
        Id = 202,
        UserId = 101,
        CategoryId = 2,
        Title = "The Art of Cooking",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "Learn some delicious recipes and culinary techniques in this post."
    },
    new Post
    {
        Id = 203,
        UserId = 103,
        CategoryId = 3,
        Title = "Data Structures and Algorithms",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "Explore fundamental data structures and algorithms used in computer science."
    },
    new Post
    {
        Id = 204,
        UserId = 104,
        CategoryId = 4,
        Title = "Traveling on a Budget",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "Discover tips and tricks for traveling on a budget without compromising on experiences."
    },
    new Post
    {
        Id = 205,
        UserId = 105,
        CategoryId = 5,
        Title = "Fitness and Wellbeing",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "Learn about various fitness routines and techniques to improve your wellbeing."
    },
    new Post
    {
        Id = 206,
        UserId = 106,
        CategoryId = 2,
        Title = "Delicious Desserts",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "Indulge in the world of delightful desserts with these recipes and tips."
    },
    new Post
    {
        Id = 207,
        UserId = 107,
        CategoryId = 6,
        Title = "Getting Started with Photography",
        PublicationDate = new DateTime(2008, 5, 1, 8, 30, 52),
        Content = "Begin your photography journey with essential tips and techniques."
    }
};

List<Tag> tags = new List<Tag>
{
  new Tag
  {
    Id = 301,
    Label = "Programming"
  },
  new Tag
  {
    Id = 302,
    Label = "Cooking"
  },
  new Tag
  {
    Id = 303,
    Label = "Data Science"
  },
  new Tag
  {
    Id = 304,
    Label = "Travel Tips"
  },
  new Tag
  {
    Id = 305,
    Label = "Fitness Motivation"
  },
  new Tag
  {
    Id = 306,
    Label = "Art Inspiration"
  },
  new Tag
  {
    Id = 307,
    Label = "Book Recommendations"
  },
  new Tag
  {
    Id = 308,
    Label = "Mental Health"
  },
  new Tag
  {
    Id = 309,
    Label = "Adventure"
  },
  new Tag
  {
    Id = 310,
    Label = "Stress Management"
  }
};

List<PostTag> postTags = new List<PostTag>
{
  new PostTag
  {
    Id = 1,
    PostId = 201,
    TagId = 301
  },
  new PostTag
  {
    Id = 2,
    PostId = 202,
    TagId = 302,
  },
  new PostTag
  {
    Id = 3,
    PostId = 203,
    TagId = 303
  },
  new PostTag
  {
    Id = 4,
    PostId = 204,
    TagId = 304
  },
  new PostTag
  {
    Id = 5,
    PostId = 205,
    TagId = 305
  },
  new PostTag
  {
    Id = 6,
    PostId = 206,
    TagId = 302
  },
  new PostTag
  {
    Id = 7,
    PostId = 207,
    TagId = 306
  }
};

List<Comment> comments = new List<Comment>
{
  new Comment
  {
    Id = 1,
    AuthorId = 101,
    PostId = 201,
    Content = "Great post! Really enjoyed reading it."
  },
  new Comment
  {
    Id = 2,
    AuthorId = 102,
    PostId = 202,
    Content = "Thanks for sharing this valuable information."
  },
  new Comment
  {
    Id = 3,
    AuthorId = 103,
    PostId = 203,
    Content = "I have a question related to the post. Can you help?"
  },
  new Comment
  {
    Id = 4,
    AuthorId = 102,
    PostId = 204,
    Content = "This post is inspiring. Keep up the great work!"
  },
  new Comment
  {
    Id = 5,
    AuthorId = 105,
    PostId = 205,
    Content = "I learned something new from this article. Thanks!"
  },
  new Comment
  {
    Id = 6,
    AuthorId = 104,
    PostId = 206,
    Content = "Your writing style is impressive. Enjoyed every bit of it."
  },
  new Comment
  {
    Id = 7,
    AuthorId = 103,
    PostId = 207,
    Content = "I have bookmarked this page for future reference. Great content!"
  },
  new Comment
  {
    Id = 8,
    AuthorId = 101,
    PostId = 201,
    Content = "I completely agree with the points mentioned in the post."
  },
  new Comment
  {
    Id = 9,
    AuthorId = 102,
    PostId = 203,
    Content = "This is exactly what I was looking for. Thank you!"
  },
  new Comment
  {
    Id = 10,
    AuthorId = 104,
    PostId = 207,
    Content = "Can't wait to read more articles from you. Well done!"
  }
};

List<Category> categories = new List<Category>
{
        new Category
        {
            Id = 1,
            Label = "Technology"
        },
        new Category
        {
            Id = 2,
            Label = "Food and Cooking"
        },
        new Category
        {
            Id = 3,
            Label = "Science"
        },
        new Category
        {
            Id = 4,
            Label = "Travel"
        },
        new Category
        {
            Id = 5,
            Label = "Fitness"
        },
        new Category
        {
            Id = 6,
            Label = "Art and Literature"
        },
        new Category
        {
            Id = 7,
            Label = "Sports"
        },
        new Category
        {
            Id = 8,
            Label = "Business and Finance"
        }
};

List<Subscription> subscriptions = new List<Subscription>
{
    new Subscription
    {
        Id = 1,
        FollowerId = 105,
        AuthorId = 101
    }, 
    new Subscription
    {
        Id = 2,
        FollowerId = 105,
        AuthorId = 102
    }
};

List<Reaction> reactiions = new List<Reaction>
{
    new Reaction { Id = 1, Emoji = 0x1F604 },
    new Reaction { Id = 2, Emoji = 0x2764 },
    new Reaction { Id = 3, Emoji = 0x1F44D },
    new Reaction { Id = 4, Emoji = 0x1F626 }
};

List<PostReaction> postReactions = new List<PostReaction>
{
    new PostReaction { Id = 1, ReactionId = 1, UserId = 101, PostId = 201 },
    new PostReaction { Id = 2, ReactionId = 2, UserId = 102, PostId = 202 },
    new PostReaction { Id = 3, ReactionId = 3, UserId = 103, PostId = 203 },
    new PostReaction { Id = 4, ReactionId = 4, UserId = 104, PostId = 204 }
};
//Create Endpoints Here!!!

//POST new comment
app.MapPost("/posts/{postId}/comments", (int postId, Comment comment) =>
{

    comment.Id = comments.Count + 1;
    comments.Add(comment);

    return Results.Ok(comment);
});

//GET a post's comment
app.MapGet("/posts/{postId}/comments", (int postId) =>
{
    var postComments = comments.Where(c => c.PostId == postId).ToList();
    return Results.Ok(postComments);
});

//DELETE a post's comment
app.MapDelete("/posts/{postId}/comments/{commentId}", (int postId, int commentId) =>
{
    var commentToDelete = comments.FirstOrDefault(c => c.Id == commentId && c.PostId == postId);

    if (commentToDelete == null)
    {
        return Results.NotFound("Comment not found.");
    }

    comments.Remove(commentToDelete);

    return Results.NoContent();
});

//GET all users
app.MapGet("/user/all", () =>
{
    return users.OrderBy(x => x.Username);
});

//GET all tags
app.MapGet("/tags", () =>
{
    List<Tag> listTags = tags.OrderBy(x => x.Label).ToList();
    return listTags;
});

//Create new User
app.MapPost("/user/new", (User newUser) =>
{
    newUser.Id = users.Max(st => st.Id) + 1;
    users.Add(newUser);
    return newUser;
});


//Delete User
app.MapDelete("/user/{id}", (int id) =>
{
    users.RemoveAll(u => u.Id == id);
});

//Get User Posts
app.MapGet("/user/{id}/posts", (int id) =>
{
    User user = users.FirstOrDefault(x => x.Id == id);
    if (user == null)
    {
        return Results.NotFound();
    }
    user.Posts = posts.Where(st => st.UserId == id).ToList();
    return Results.Ok(user);
});

//Update Service Ticket
app.MapPut("/user/{id}/update", (int id, User user) =>
{
    User userToUpdate = users.FirstOrDefault(st => st.Id == id);
    int userIndex = users.IndexOf(userToUpdate);
    if (userToUpdate == null)
    {
        return Results.NotFound();
    }
    // the id in the request route doesn't match the id from the ticket in the request body. That's a bad request!
    if (id != user.Id)
    {
        return Results.BadRequest();
    }
    users[userIndex] = user;
    return Results.Ok();
});


//GET All Posts
app.MapGet("/posts", () =>
{
    return posts;
});

//GET Post Details
app.MapGet("/posts/{id}", (int id) =>
{
    Post post = posts.FirstOrDefault(p => p.Id == id);
    if (post == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(post);
});

//POST New Post
app.MapPost("/posts", (Post post) =>
{
    post.Id = posts.Max(p => p.Id) + 1;
    posts.Add(post);
    return post;
});


// ADD Tags to a Post
app.MapPost("/posts/{id}/tags", (int id, int tagId) =>
{
    int postTagsId = postTags.Max(p => p.Id) + 1;
    PostTag newPostTag = new PostTag()
    {
        Id = postTagsId,
        TagId = tagId,
        PostId = id
    };
    postTags.Add(newPostTag);
    return postTags;
});

//DELETE Post
app.MapDelete("/posts/{id}", (int id) =>
{
    Post post = posts.FirstOrDefault(p => p.Id == id);
    posts.Remove(post);
    return posts;
});

//create category
app.MapPost("/categories/{Id}", (Category category) =>
{
    category.Id = categories.Max(cat => cat.Id) + 1;
    categories.Add(category);
    return category;
});

//view all categories
app.MapGet("/categories", () =>
{
    return categories;
});

//DELETE PostTags
app.MapDelete("/posts/{postId}/tags", (int postId, int tagId) =>
{
    postTags.RemoveAll(pt =>  pt.PostId == postId && pt.TagId == tagId);
    return postTags;
});

//View all subscriptions
app.MapGet("/subscription", () =>
{
    return subscriptions;
});

//Subscribe to User
app.MapPost("/subscription", (int followerId, int authorId) =>
{
int subscriptionId = subscriptions.Max(p => p.Id) + 1;
Subscription newSub = new Subscription()
{
Id = subscriptionId,
FollowerId = followerId,
AuthorId = authorId,
CreatedOn = DateTime.Now
};
subscriptions.Add(newSub);

});

//Delete User
app.MapDelete("/subscription/{followerId}/{authorId}", (int followerId, int authorId) =>
{
    subscriptions.RemoveAll(u => u.FollowerId == followerId && u.AuthorId == authorId);
});

//View Posts for all subscriptions
app.MapGet("/subscription/{id}/post", (int id) =>
{
    var subList = subscriptions.Where(s => s.FollowerId == id).ToList();
    List<Post> postList= new List<Post>();
  
    var postsFromSubscriptions = from subscription in subscriptions
                                 where subscription.FollowerId == id
                                 join post in posts on subscription.AuthorId equals post.UserId
                                 select post;

    foreach (var post in postsFromSubscriptions)
    {
        postList.Add(post);
    }

    return postList;

});

//ADD Reaction To Post
app.MapPost("/posts/{postId}/reactions", (int postId, PostReaction newReaction) =>
{
    int postReactionId = postReactions.Max(pr => pr.Id) + 1;

    PostReaction postReactionToAdd = new PostReaction()
    {
        Id = postReactionId,
        ReactionId = newReaction.ReactionId,
        UserId = newReaction.UserId,
        PostId = postId
    };

    postReactions.Add(postReactionToAdd);

    return postReactions;
});

//DELETE Post Reaction
app.MapDelete("/posts/{postId}/reactions/{reactionId}", (int postId, int reactionId) =>
{
    postReactions.RemoveAll(pr => pr.PostId == postId && pr.ReactionId == reactionId);
    return postReactions;
});

app.Run();