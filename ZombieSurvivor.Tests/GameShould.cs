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
        public void AddOneSurvivorToGame()
        {
            var survivor = new Survivor("Sam");
            game.AddSurvivor(survivor);

            game.Players.Count.ShouldBe(1);
            game.Players.First().Name.ShouldBe("Sam");
        }
        
        [Fact]
        public void GameStartsWithZeroPlayersByDefault()
        {
            game.Players.Count.ShouldBe(0);
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

        [Fact] public void KnowIfAllPlayersAreDead()
        {
            var survivor1 = new Survivor("Sam");
            var survivor2 = new Survivor("Robin");

            game.AddSurvivor(survivor1);
            game.AddSurvivor(survivor2);
      
            KillSurvivor(survivor1);
            KillSurvivor(survivor2);

            game.AllPlayersAreDead().ShouldBeTrue();
        }

        private static void KillSurvivor(Survivor survivor)
        {
            survivor.Injure();
            survivor.Injure();
        }
    }
}