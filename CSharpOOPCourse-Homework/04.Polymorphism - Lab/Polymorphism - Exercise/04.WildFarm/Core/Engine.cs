/*
4
Druid
Druid
Warrior
Warrior
Rogue
Rogue
Paladin
Paladin
250
 */

using Raiding.Core.Interfaces;
using Raiding.Factories.Interfaces;
using Raiding.IO.Interfaces;
using Raiding.Models.Interfaces;

namespace Raiding.Core
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;
        private readonly IBaseHeroFactory baseHeroFactory;

        private readonly ICollection<IBaseHero> heroes;

        public Engine(IReader reader, IWriter writer, IBaseHeroFactory baseHeroFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.baseHeroFactory = baseHeroFactory;
            this.heroes = new List<IBaseHero>();
        }

        public void Run()
        {
            int numberOfLines = int.Parse(reader.ReadLine());

            while (heroes.Count < numberOfLines)
            {
                try
                {
                    string heroName = reader.ReadLine();
                    string heroType = reader.ReadLine();
                    CreateBaseHero(heroes, heroType, heroName);
                }
                catch (Exception ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }

            int bossPower = int.Parse(reader.ReadLine());
            int totalHeroesPower = heroes.Sum(h => h.Power);

            foreach (var hero in heroes)
            {
                writer.WriteLine(hero.CastAbility());
            }

            if (totalHeroesPower >= bossPower)
            {
                writer.WriteLine("Victory!");
            }
            else
            {
                writer.WriteLine("Defeat...");
            }
        }

        private void CreateBaseHero(ICollection<IBaseHero> heroes, string heroType, string heroName)
        {
            IBaseHero baseHero = baseHeroFactory.CreateHero(heroType, heroName);
            heroes.Add(baseHero);
        }
    }
}