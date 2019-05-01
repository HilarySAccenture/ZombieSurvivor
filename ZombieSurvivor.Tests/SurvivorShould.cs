using ZombieSurvivor;
using Shouldly;
using Xunit;

namespace ZombieSurvivor.Tests
{
    public class SurvivorShould
    {
        [Fact]
        public void HaveOneWoundWhenInjuredOnce()
        {
            var survivor = new Survivor("Sam", 0);

            survivor.Injure();

            survivor.Wounds.ShouldBe(1);
        }
    }
}