var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/health", () =>
    Results.Ok(new { status = "Healthy" }));

app.MapGet("/api/todos", () =>
{
    var todos = new[]
    {
        new
        {
            id = 1,
            title = "Learn Docker",
            completed = true
        },
        new
        {
            id = 2,
            title = "Learn Kubernetes",
            completed = false
        },
        new
        {
            id = 3,
            title = "Learn Helm",
            completed = false
        }
    };

    return Results.Ok(todos);
});

app.Run();
