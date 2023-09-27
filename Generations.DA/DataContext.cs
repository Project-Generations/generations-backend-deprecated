using Generations.DA.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Generations.DA
{
    public class DataContext : DbContext
    {
        protected IConfiguration Configuration { get; set; }

        public DataContext(DbContextOptions<DataContext> options, IConfiguration configuration) : base(options)
        {
            Configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>().ToTable("pokemons");
            modelBuilder.Entity<CreatedPokemon>().ToTable("created_pokemons");
            modelBuilder.Entity<Item>().ToTable("items");
            modelBuilder.Entity<Move>().ToTable("moves");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<CreatedPokemon> CreatedPokemons { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Move> Moves { get; set; }
    }
}