using NUnit.Framework;
using ProductionLibrary;
using System.Threading.Tasks;

namespace NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async void Nunit_Async_Void() =>
            await new TestAsync().Foo(o => Assert.AreEqual(32, o));

        [Test]

        public async Task Nunit_Async_Task() =>
            await new TestAsync().Foo(o => Assert.AreEqual(32, o));
    }
}