using Generations.DA.Models;

namespace Generations.DA
{
    public class DbSeeder
    {

        public DbSeeder()
        {

        }

        public static void Initialize(DataContext context)
        {
            Moves tackle = new Moves()
            {
                Name = "Tackle",
                Description = "Tackle is one of the most common and basic moves a Pokémon learns. It deals damage with no additional effects.",
                Type = "Normal",
                PowerPoints = 35,
                Power = 40,
                Accuracy = 100,
                Category = "Physical"
            };

            Moves quickAttack = new Moves()
            {
                Name = "Quick Attack",
                Description = "Quick Attack deals damage and has a priority of +1.",
                Type = "Normal",
                PowerPoints = 30,
                Power = 40,
                Accuracy = 100,
                Category = "Physical"
            };

            if (context.Pokemons.Any())
            {
                return;
            }

            var pokemons = new Pokemons[]
            {
                new Pokemons
                {
                    Id=1,
                    Name="Bulbasaur",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png",
                    Type="Grass",
                    Stats = new Stats
                    {
                        BaseHp=45,
                        BaseAttack=49,
                        BaseDefense=49,
                        BaseSpecialAttack=65,
                        BaseSpecialDefense=65,
                        BaseSpeed=45,
                    },
                    Moves = { tackle, quickAttack },
                },
                new Pokemons
                {
                    Id=2,
                    Name="Charmander",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png",
                    Type="Fire",
                    Stats = new Stats
                    {
                        BaseHp=39,
                        BaseAttack=52,
                        BaseDefense=43,
                        BaseSpecialAttack=60,
                        BaseSpecialDefense=50,
                        BaseSpeed=65,
                    },
                    Moves = { tackle, quickAttack },
                },
                new Pokemons
                {
                    Id=3,
                    Name="Squirtle",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png",
                    Type="Water",
                    Stats = new Stats
                    {
                        BaseHp=44,
                        BaseAttack=48,
                        BaseDefense=65,
                        BaseSpecialAttack=50,
                        BaseSpecialDefense=64,
                        BaseSpeed=43,
                    },
                    Moves = { tackle, quickAttack },
                },
            };

            foreach (Pokemons pokemon in pokemons)
            {
                context.Pokemons.Add(pokemon);
            }
            context.SaveChanges();
        }
    }
}
