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
            var katana = new Katana();

            survivor.AcquireEquipment(katana);

            survivor.Arsenal.Count.ShouldBe(1);
        }

        [Fact]
        public void CanAcquireNoMoreThanFivePiecesOfEquipmentWhenZeroWounds()
        {
            var katana = new Katana();
            for (var i = 0; i < 10; i++)
            {
                survivor.AcquireEquipment(katana);
            }
            
            survivor.Arsenal.Count.ShouldBe(5);
        }

        [Fact]
        public void LosesOneEquipmentCarryingCapacityWhenWoundedOnce()
        {
            var katana = new Katana();
            var carryingCapacity = 5;
            for (var i = 0; i < carryingCapacity; i++)
            {
                survivor.AcquireEquipment(katana);
            }
            survivor.Injure();
            
            survivor.Arsenal.Count.ShouldBe(4);   
        }
        
        
    }
}