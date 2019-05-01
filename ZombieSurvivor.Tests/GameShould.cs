using System.Linq;
using Xunit;
using ZombieSurvivor;
using Shouldly;


namespace ZombieSurvivor.Tests
{
    public class GameShould
    {
        [Fact]
        public void CanAddSurvivors()
        {
            var game = new Game();
            var survivor = new Survivor("Sam");
            game.AddSurvivor(survivor);

            game.SurvivorGroup.Count.ShouldBe(1);
            game.SurvivorGroup.First().Value.ShouldBe("Sam");
        }
    }
}