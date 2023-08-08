using Microsoft.AspNetCore.Builder;

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

//Create Endpoints Here!!!

//create category
app.MapPost("/Categories/{Id}", (Categories Category) =>
{
    Category.Id = Category.Max(cat => cat.Id) + 1;
    Category.Add(Category)
    return Results.Ok(Categories);
});

//view all categories
app.MapGet("/Categories", () =>
{
    return Categories;
});

//filter all posts by category id
app.MapGet("/Posts/Categories/{Id}", (int Id) =>
{
    var filteredPosts = Posts.Where(post => categoryIds.Contains(post.CategoryId));
    return Results.Ok(filteredPosts);

});

app.Run();
