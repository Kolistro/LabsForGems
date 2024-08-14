using MyExtensions;

namespace MyExtensions.Tests
{
    public class FirstOrDefaultTest
    {
        [Fact]
        public void ReturnedElementIsEqualToFirstElementOfCollection()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.Equal(5, list.FirstOrDefault());
        }

        [Fact]
        public void ReturnedElementMatchesCondition()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.Equal(-1, list.FirstOrDefault(l => l <= 0));
        }

        [Fact]
        public void PassedEmptyCollection()
        {
            // Arrange.
            List<int> list = new List<int>();

            // Act + assert.
            Assert.Equal(0, list.FirstOrDefault(l => l <= 0));
        }


        [Fact]
        public void PassedNullCollection()
        {
            // Arrange.
            List<Object>? list = null;

            // Act + assert.
            Assert.Null(list.FirstOrDefault());
        }

        [Fact]
        public void NoElementOfCollectionSatisfiesCondition()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.Equal(0, list.FirstOrDefault(l => l >= 100));
        }
    }
}
