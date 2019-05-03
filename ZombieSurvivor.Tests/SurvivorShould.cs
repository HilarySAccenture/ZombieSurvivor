using System.Diagnostics.SymbolStore;
using ZombieSurvivor;
using Shouldly;
using Xunit;

namespace ZombieSurvivor.Tests
{
    public class SurvivorShould
    {
        Survivor survivor = new Survivor("Sam", 0);
        Katana katana = new Katana();

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

            var result = survivor.IsDead();
            result.ShouldBeFalse();
        }

        [Fact]
        public void BeDeadAfterBeingWoundedTwice()
        {
            survivor.Injure();
            survivor.Injure();

            var result = survivor.IsDead();
            result.ShouldBeTrue();            
        }

        [Fact]
        public void HaveNoMoreThanTwoWounds()
        {
            for (var i = 0; i < 3; i++)
            {
                survivor.Injure();
            }

            survivor.Wounds.ShouldBe(2);
        }

        [Fact]
        public void AcquireOnePieceOfEquipment()
        {
            survivor.AcquireEquipment(katana);

            survivor.Arsenal.Count.ShouldBe(1);
        }

        [Fact]
        public void AcquireNoMoreThanFivePiecesOfEquipmentWhenZeroWounds()
        {
            for (var i = 0; i < 10; i++)
            {
                survivor.AcquireEquipment(katana);
            }
            
            survivor.Arsenal.Count.ShouldBe(5);
        }

        [Fact]
        public void LoseOneEquipmentCarryingCapacityWhenWoundedOnce()
        {
            var carryingCapacity = 5;
            for (var i = 0; i < carryingCapacity; i++)
            {
                survivor.AcquireEquipment(katana);
            }
            survivor.Injure();
            
            survivor.Arsenal.Count.ShouldBe(4);   
        }

        [Fact]
        public void GainOneExperienceAfterKillingOneZombie()
        {
            survivor.KillZombie();

            survivor.Experience.ShouldBe(1);
        }

        [Fact]
        public void ShouldBeAtLevelBlueWithOneExperience()
        {
            survivor.KillZombie();
            
            survivor.Level.ShouldBe("Blue");
        }
      
       
    }
}