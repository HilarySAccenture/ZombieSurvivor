using System.Linq;
using Xunit;
using ZombieSurvivor;
using Shouldly;


namespace ZombieSurvivor.Tests
{
    public class GameShould
    {
        Game game = new Game();
        [Fact]
        public void CanAddOneSurvivorToGame()
        {
            var survivor = new Survivor("Sam");
            game.AddSurvivor(survivor);

            game.Players.Count.ShouldBe(1);
            game.Players.First().Name.ShouldBe("Sam");
        }

        [Fact]
        public void CanAddTwoSurvivorsToGame()
        {
            var survivor1 = new Survivor("Sam");
            var survivor2 = new Survivor("Robin");
            
            game.AddSurvivor(survivor1);
            game.AddSurvivor(survivor2);
            
            game.Players.Count.ShouldBe(2);
            game.Players.First().Name.ShouldBe("Sam");
            game.Players[1].Name.ShouldBe("Robin");
        }

        [Fact]
        public void CannotHaveTwoSurvivorsWithTheSameName()
        {
            var survivor1 = new Survivor("Sam");
            var survivor2 = new Survivor("Sam");
            
            game.AddSurvivor(survivor1);
            game.AddSurvivor(survivor2);
            
            game.Players.Count.ShouldBe(1);
        }
        
    }
}