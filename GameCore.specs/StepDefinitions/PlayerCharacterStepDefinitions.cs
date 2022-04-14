using System;
using TechTalk.SpecFlow;
using Xunit;

namespace GameCore.specs.StepDefinitions
{
    [Binding]
    public class PlayerCharacterStepDefinitions
    {
        private PlayerCharacter _player;

        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
            _player=new PlayerCharacter();
        }

        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
            _player.Hit(0);
        }

        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe100()
        {
            Assert.Equal(100, _player.Health);
        }

        [When(@"I take 40 damage")]
        public void WhenITake40Damage()
        {
            _player.Hit(40);
        }

        [Then(@"My health should now be 60")]
        public void ThenMyHealthShouldNowBe()
        {
            Assert.Equal(60, _player.Health);
        }

    }
}
