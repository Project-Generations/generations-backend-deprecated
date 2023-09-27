using Generations.DA;
using Generations.DA.Data;
using Pokemon.BL.Interfaces;
using Pokemon.BL.Services;

var builder = WebApplication.CreateBuilder(args);

//Dependency inversion
builder.Services.AddScoped<iPokemonService, PokemonService>();
builder.Services.AddScoped<iPokemon, PokemonDA>();

// Add services to the container.
builder.Services.AddDbContext<DataContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Enforce lowercase urls
builder.Services.Configure<RouteOptions>(options =>
{
    options.LowercaseUrls = true;
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<DataContext>();
    context.Database.EnsureCreated();
    DbSeeder.Initialize(context);
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
