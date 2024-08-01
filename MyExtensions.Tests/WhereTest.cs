namespace MyExtensions.Tests
{
    public class WhereTest
    {

        [Fact]
        public void ReturnedElementsMatchesCondition()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };
            List<int> expected = new List<int> {-1, 0, -10};

            // Act + assert.
            Assert.Equal(expected, list.Where(l => l <= 0));
        }

        [Fact]
        public void PassedEmptyCollection()
        {
            // Arrange.
            List<int> list = new List<int>();

            // Act + assert.
            Assert.Throws<ArgumentNullException>(() => list.Where(l => l <= 0));
        }


        [Fact]
        public void PassedNullCollection()
        {
            // Arrange.
            List<int> list = null;

            // Act + assert.
            Assert.Throws<ArgumentNullException>(() => list.Where(l => l <= 0));
        }

        [Fact]
        public void NoElementsOfCollectionSatisfiesCondition()
        {
            // Arrange.
            List<int> list = new List<int> { 5, 6, 9, -1, 0, 10, 35, -10 };
            List<int> expected =  new List<int>();

            // Act + assert.
            Assert.Equal(expected, list.Where(l => l >= 100));
        }
    }
}
