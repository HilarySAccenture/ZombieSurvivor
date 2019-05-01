using System.Linq;
using Xunit;
using ZombieSurvivor;
using Shouldly;


namespace ZombieSurvivor.Tests
{
    public class GameShould
    {
        [Fact]
        public void CanAddOneSurvivorToGame()
        {
            var game = new Game();
            var survivor = new Survivor("Sam");
            game.AddSurvivor(survivor);

            game.SurvivorGroup.Count.ShouldBe(1);
            game.SurvivorGroup.First().Name.ShouldBe("Sam");
        }

        [Fact]
        public void CanAddTwoSurvivorsToGame()
        {
            var game = new Game();
            var survivor1 = new Survivor("Sam");
            var survivor2 = new Survivor("Robin");
            
            game.AddSurvivor(survivor1);
            game.AddSurvivor(survivor2);
            
            game.SurvivorGroup.Count.ShouldBe(2);
            game.SurvivorGroup.First().Name.ShouldBe("Sam");
            game.SurvivorGroup[1].Name.ShouldBe("Robin");
        }

        [Fact]
        public void CannotHaveTwoSurvivorsWithTheSameName()
        {
            var game = new Game();
            var survivor1 = new Survivor("Sam");
            var survivor2 = new Survivor("Sam");
            
            game.AddSurvivor(survivor1);
            game.AddSurvivor(survivor2);
            
            game.SurvivorGroup.Count.ShouldBe(1);
        }
        
    }
}