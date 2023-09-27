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

            // Look for any students.
            if (context.Pokemons.Any())
            {
                return;   // DB has been seeded
            }

            var pokemons = new Pokemons[]
            {
                new Pokemons
                {
                    PokemonId=1,
                    Name="Bulbasaur",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/1.png",
                    Type="Grass",
                    BaseHp=45,
                    BaseAttack=49,
                    BaseDefense=49,
                    BaseSpecialAttack=65,
                    BaseSpecialDefense=65,
                    BaseSpeed=45,
                },

                new Pokemons
                {
                    PokemonId=2,
                    Name="Charmander",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png",
                    Type="Fire",
                    BaseHp=39,
                    BaseAttack=52,
                    BaseDefense=43,
                    BaseSpecialAttack=60,
                    BaseSpecialDefense=50,
                    BaseSpeed=65,
                },

                new Pokemons
                {
                    PokemonId=3,
                    Name="Squirtle",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png",
                    Type="Water",
                    BaseHp=44,
                    BaseAttack=48,
                    BaseDefense=65,
                    BaseSpecialAttack=50,
                    BaseSpecialDefense=64,
                    BaseSpeed=43,
                },
            };

            context.Pokemons.AddRange(pokemons);
            context.SaveChanges();
        }
    }
}
