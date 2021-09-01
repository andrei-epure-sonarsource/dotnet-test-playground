using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductionLibrary;
using System.Threading.Tasks;

namespace MSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async void MSTest_Async_Void() =>
            await new TestAsync().Foo(o => Assert.AreEqual(32, o));

        [TestMethod]
        public async Task MSTest_Async_Task() =>
            await new TestAsync().Foo(o => Assert.AreEqual(32, o));
    }
}
