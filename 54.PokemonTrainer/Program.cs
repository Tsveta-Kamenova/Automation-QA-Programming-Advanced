namespace _54.PokemonTrainer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Trainer
    {
        public string Name { get; }
        public int Badges { get; set; }
        public List<Pokemon> Pokemons { get; }

        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemons = new List<Pokemon>();
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemons.Count}";
        }
    }

    class Pokemon
    {
        public string Name { get; }
        public string Element { get; }
        public int Health { get; set; }

        public Pokemon(string name, string element, int health)
        {
            Name = name;
            Element = element;
            Health = health;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            string input;
            while ((input = Console.ReadLine()) != "Tournament")
            {
                string[] tokens = input.Split();
                string trainerName = tokens[0];
                string pokemonName = tokens[1];
                string pokemonElement = tokens[2];
                int pokemonHealth = int.Parse(tokens[3]);

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (!trainers.ContainsKey(trainerName))
                {
                    Trainer trainer = new Trainer(trainerName);
                    trainers.Add(trainerName, trainer);
                }

                trainers[trainerName].Pokemons.Add(pokemon);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string element = input;

                foreach (var trainer in trainers.Values)
                {
                    if (trainer.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Badges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }

                        trainer.Pokemons.RemoveAll(p => p.Health <= 0);
                    }
                }
            }

            foreach (var trainer in trainers.Values
                .OrderByDescending(t => t.Badges))
            {
                Console.WriteLine(trainer);
            }
        }
    }

}