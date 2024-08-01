using MyExtensions;

namespace MyExtensions.Tests
{
    public class AnyTest
    {
        [Fact]
        public void ReturnedTrueIfPredicateIsNull()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.True(list.Any());
        }

        [Fact]
        public void ReturnsTrueIfElementIsFound()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.True(list.Any(l => l <= 0));
        }

        [Fact]
        public void PassedEmptyCollection()
        {
            // Arrange.
            List<int> list = new List<int>();

            // Act + assert.
            Assert.Throws<ArgumentNullException>(() => list.Any(l => l <= 0));
        }


        [Fact]
        public void PassedNullCollection()
        {
            // Arrange.
            List<int> list = null;

            // Act + assert.
            Assert.Throws<ArgumentNullException>(() => list.Any());
        }

        [Fact]
        public void ReturnsFalseIfElementIsNotFound()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };

            // Act + assert.
            Assert.False(list.Any(l => l >= 100));
        }

    }
}
