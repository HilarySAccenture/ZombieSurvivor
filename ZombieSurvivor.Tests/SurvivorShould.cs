using System.Diagnostics.SymbolStore;
using ZombieSurvivor;
using Shouldly;
using Xunit;

namespace ZombieSurvivor.Tests
{
    public class SurvivorShould
    {
        Survivor survivor = new Survivor("Sam", 0);
        [Fact]
        public void HaveOneWoundWhenInjuredOnce()
        {
            survivor.Injure();

            survivor.Wounds.ShouldBe(1);
        }

        [Fact]
        public void HaveTwoWoundsWhenInjuredTwice()
        {
            survivor.Injure();
            survivor.Injure();
            
            survivor.Wounds.ShouldBe(2);
        }

        [Fact]
        public void BeAliveWithOneWound()
        {
            survivor.Injure();

            survivor.IsAlive().ShouldBeTrue();
        }

        [Fact]
        public void BeDeadAfterBeingWoundedTwice()
        {
            survivor.Injure();
            survivor.Injure();
            
            survivor.IsAlive().ShouldBeFalse();
        }

        [Fact]
        public void CannotHaveMoreThanTwoWounds()
        {
            for (var i = 0; i < 3; i++)
            {
                survivor.Injure();
            }
            
            survivor.Wounds.ShouldBe(2);
        }

        [Fact]
        public void CanAcquireOnePieceOfEquipment()
        {
            var brassKnuckles = new BrassKnuckles();
            survivor.AcquireEquipment(brassKnuckles);

            survivor.Arsenal.Count.ShouldBe(1);
        }
    }
}