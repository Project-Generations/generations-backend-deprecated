using Generations.DA.Entities;
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
            modelBuilder.Entity<Pokemons>().ToTable("pokemons");
            modelBuilder.Entity<CreatedPokemons>().ToTable("created_pokemons");
            modelBuilder.Entity<Items>().ToTable("items");
            modelBuilder.Entity<Moves>().ToTable("moves");
            modelBuilder.Entity<Stats>().ToTable("stats");
            modelBuilder.Entity<Abilities>().ToTable("abilities");
            modelBuilder.Entity<Types>().ToTable("types");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Pokemons> Pokemons { get; set; }
        public DbSet<CreatedPokemons> CreatedPokemons { get; set; }
        public DbSet<Items> Items { get; set; }
        public DbSet<Moves> Moves { get; set; }
        public DbSet<Stats> Stats { get; set; }
        public DbSet<Abilities> Abilities { get; set; }
        public DbSet<Types> Types { get; set; }
    }
}