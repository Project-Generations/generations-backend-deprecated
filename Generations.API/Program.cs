using Generations.DA;
using Generations.DA.Data;
using Generations.ItemManager.Interfaces;
using Generations.ItemManager.Services;
using Generations.PokemonManager.Interfaces;
using Generations.PokemonManager.Services;

var builder = WebApplication.CreateBuilder(args);

//Dependency inversion
builder.Services.AddScoped<iPokemonService, PokemonService>();
builder.Services.AddScoped<iPokemon, PokemonDA>();

builder.Services.AddScoped<iItemService, ItemService>();
builder.Services.AddScoped<iItem, ItemDA>();

// Add services to the container.
builder.Services.AddDbContext<DataContext>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
        });
});

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

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();