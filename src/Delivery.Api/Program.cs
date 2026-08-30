using Delivery.Api;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return Results.Ok(new
    {
        application = "Delivery API",
        status = "running"
    });
});

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        status = "healthy"
    });
});

app.MapGet("/add", (int a, int b) =>
{
    return Results.Ok(new
    {
        a,
        b,
        result = Calculator.Add(a, b)
    });
});

app.MapGet("/multiply", (int a, int b) =>
{
    return Results.Ok(new
    {
        a,
        b,
        result = Calculator.Multiply(a, b)
    });
});

app.Run();
