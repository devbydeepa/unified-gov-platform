var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();       // Controllers
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();        // Swagger / OpenAPI

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization(); // Placeholder for JWT later

app.MapControllers();    // Map controller routes


app.Run();

