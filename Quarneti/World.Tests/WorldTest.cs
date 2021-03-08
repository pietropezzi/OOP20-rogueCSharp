using Xunit;

namespace World.Tests
{
    public class WorldTest
    {
        [Fact]
        public void WorldCreationTest()
        {
            var player = new Entity();
            World w = new World(player);
            Assert.NotNull(w);
            Assert.NotEmpty(w.TileMap);
        }
    }
}
