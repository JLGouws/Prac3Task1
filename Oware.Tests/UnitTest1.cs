using NUnit.Framework;
using NSubstitute;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void WhenCreatingHouseSeedCountIs4()
        {
            // ARRANGE:
            House h = new House(0, 0);//this is self explanatory
            h.AddSeedInPot(new Seed());
            h.AddSeedInPot(new Seed());
            // ACT:
            h.ResetHouse();
            // ASSERT:
            Assert.AreEqual(4, h.GetCount(), "New houses must have 4 seeds in them.");
        }

        [Test]
        public void WhenAddingSeedToHouseCountIsCorrect() {//using the NSubstitute library
            // ARRANGE:
            int counter = 0;
            IScoreHouse mockScoreHouse = Substitute.For<IScoreHouse>(); //create a mock object
            mockScoreHouse.When(x => x.AddSeed(Arg.Any<Seed>())).Do(x => counter++); //n substitutes way to call void methods
            Player p = new Player("Bob", mockScoreHouse);//player
            // ACT:
            p.AddSeedToScoreHouse(new Seed());
            p.AddSeedToScoreHouse(new Seed());//call the method that we are testing twice.
            // ASSERT:
            Assert.AreEqual(2, counter, "Adding seeds to a pot increases the number of seeds in the pot.");
            mockScoreHouse.Received().AddSeed(Arg.Any<Seed>());
        }
    }
}
