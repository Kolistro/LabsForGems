using MyExtensions;

namespace MyExtensions.Tests
{
    public class FirstTest
    {
        [Fact]
        public void ReturnedElementIsEqualToFirstElementOfCollection()
        {
            // Arrange.
            List<int> list = new List<int> {5, 6, 9, -1, 0, 10, 35, -10 };


            // Act + assert.
            Assert.Equal(5, list.First());
        }

        [Fact]
        public void ReturnedElementMatchesCondition()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.Equal(-1, list.First(l => l <= 0));
        }

        [Fact]
        public void PassedEmptyCollection()
        {
            // Arrange.
            List<int> list = new List<int>();

            // Act + assert.
            Assert.Throws<ArgumentNullException>(() => list.First(l => l <= 0));
        }


        [Fact]
        public void PassedNullCollection()
        {
            // Arrange.
            List<int> list = null;

            // Act + assert.
            Assert.Throws<ArgumentNullException>(() => list.First());
        }

        [Fact]
        public void NoElementOfCollectionSatisfiesCondition() 
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.Throws<InvalidOperationException>(() => list.First(l => l >= 100));
        }

    }
}