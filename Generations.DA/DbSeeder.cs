using Generations.DA.Entities;

namespace Generations.DA
{
    public class DbSeeder
    {
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

            Moves vineWhip = new Moves()
            {
                Name = "Vine Whip",
                Description = "The target is struck with slender, whiplike vines to inflict damage.",
                Type = "Grass",
                PowerPoints = 25,
                Power = 45,
                Accuracy = 100,
                Category = "Physical"
            };

            Moves ember = new Moves()
            {
                Name = "Ember",
                Description = "The target is attacked with small flames. This may also leave the target with a burn.",
                Type = "Fire",
                PowerPoints = 25,
                Power = 40,
                Accuracy = 100,
                Category = "Special"
            };

            //Bulbasaurs stats mockdata
            Stats BulbasaurHp = new()
            {
                Name = "HP",
                Value = 45
            };

            Stats BulbasaurAttack = new()
            {
                Name = "Attack",
                Value = 49
            };

            Stats BulbasaurDefense = new()
            {
                Name = "Defense",
                Value = 49
            };

            Stats BulbasaurSpecialAttack = new()
            {
                Name = "Special Attack",
                Value = 65
            };

            Stats BulbasaurSpecialDefense = new()
            {
                Name = "Special Defense",
                Value = 65
            };

            Stats BulbasaurSpeed = new()
            {
                Name = "Speed",
                Value = 45
            };

            //Charmanders stats mockdata
            Stats CharmanderHp = new()
            {
                Name = "HP",
                Value = 39
            };

            Stats CharmanderAttack = new()
            {
                Name = "Attack",
                Value = 52
            };

            Stats CharmanderDefense = new()
            {
                Name = "Defense",
                Value = 43
            };

            Stats CharmanderSpecialAttack = new()
            {
                Name = "Special Attack",
                Value = 60
            };

            Stats CharmanderSpecialDefense = new()
            {
                Name = "Special Defense",
                Value = 50
            };

            Stats CharmanderSpeed = new()
            {
                Name = "Speed",
                Value = 65
            };

            //Squirtles stats mockdata
            Stats SquirtleHp = new()
            {
                Name = "HP",
                Value = 44
            };

            Stats SquirtleAttack = new()
            {
                Name = "Attack",
                Value = 48
            };

            Stats SquirtleDefense = new()
            {
                Name = "Defense",
                Value = 65
            };

            Stats SquirtleSpecialAttack = new()
            {
                Name = "Special Attack",
                Value = 50
            };

            Stats SquirtleSpecialDefense = new()
            {
                Name = "Special Defense",
                Value = 64
            };

            Stats SquirtleSpeed = new()
            {
                Name = "Speed",
                Value = 43
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
                    Stats = { BulbasaurHp, BulbasaurAttack, BulbasaurDefense, BulbasaurSpecialAttack, BulbasaurSpecialDefense, BulbasaurSpeed },
                    Moves = { tackle, quickAttack, vineWhip },
                },
                new Pokemons
                {
                    Id=2,
                    Name="Charmander",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/4.png",
                    Type="Fire",
                    Stats = { CharmanderHp, CharmanderAttack, CharmanderDefense, CharmanderSpecialAttack, CharmanderSpecialDefense, CharmanderSpeed },
                    Moves = { tackle, quickAttack, ember },
                },
                new Pokemons
                {
                    Id=3,
                    Name="Squirtle",
                    Sprite="https://raw.githubusercontent.com/PokeAPI/sprites/master/sprites/pokemon/other/official-artwork/7.png",
                    Type="Water",
                    Stats = { SquirtleHp, SquirtleAttack, SquirtleDefense, SquirtleSpecialAttack, SquirtleSpecialDefense, SquirtleSpeed },
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
