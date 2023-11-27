var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseFileServer();

app.UseMvcWithDefaultRoute();

app.Run(async context =>
{
    await context.Response.WriteAsync("Hello world!");
});
app.Run();