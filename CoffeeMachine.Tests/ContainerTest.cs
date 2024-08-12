
namespace CoffeeMachine.Tests
{
    public class ContainerTest
    {
        [Fact]
        public void CreateContainer_NormalCapacity_Success()
        {
            // Arrange.
            const int capacity = 10;

            // Act.
            var container = new Container(capacity);

            // Assert.
            Assert.Equal(capacity, container.GetCapacity());
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(3001)]
        public void CreateContainer_InvalidCapacity_Throws(int capacity)
        {
            // Act + Assert.
            Assert.Throws<ArgumentException>(() => new Container(capacity));
        }

        [Fact]
        public void LoadResource_WithGivenNormalValue_Success()
        {
            // Arrange.
            var container = new Container(10);
            const int resource = 5;

            // Act.
            container.LoadResource(resource);

            // Assert.
            Assert.Equal(resource, container.GetValue());
        }

        [Theory]
        [InlineData(20)]
        [InlineData(-1)]
        public void LoadResource_InvalidValue_Throws(int resource)
        {
            // Arrange.
            var container = new Container(10);

            // Act + Assert.
            Assert.Throws<ArgumentException>(() => container.LoadResource(resource));
        }

        [Fact]
        public void GetResource_WithGivenNormalValue_Success()
        {
            // Arrange.
            var container = new Container(10);
            const int resource = 5;
            container.LoadResource(resource);
            
            // Act.
            int withdrawnResource = container.GetResource(resource);

            // Assert.
            Assert.Equal(resource, withdrawnResource);
            Assert.Equal(0, container.GetValue());

        }

        [Theory]
        [InlineData(20)]
        [InlineData(-1)]
        public void GetResource_WithGivenInvalidValue_Throws(int resource)
        {
            // Arrange.
            var container = new Container(10);

            // Act + Assert.
            Assert.Throws<ArgumentException>(() => container.GetResource(resource));
        }
    }
}