using System;
using Xunit;
using ZombieSurvivor;
using Shouldly;

namespace ZombieSurvivor.Tests
{
    public class SurvivorShould
    {
        [Fact]
        public void BeAliveByDefault()
        {
            var survivor = new Survivor("Sam", 0);
            
            survivor.IsAlive().ShouldBeTrue();
        }
    }
}