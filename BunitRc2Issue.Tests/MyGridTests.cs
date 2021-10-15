using Bunit;
using Xunit;

namespace BunitRc2Issue.Tests
{
    public class MyGridTests : TestContext
    {
        [Fact]
        public void TestFails()
        {
            var cut = RenderComponent<MyGrid>();
        }
    }
}