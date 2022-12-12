using RucksackPriorities;

namespace NUnitTests
{
    [TestFixture]
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void DefineItemPriorities_WhenCalled_ReturnsCorrectLength()
        {
            var result = DefinePriorities.DefineItemPriorities();
            Assert.That(result.Count, Is.EqualTo(52));
        }
    }
}