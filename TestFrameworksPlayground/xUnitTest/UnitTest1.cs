using ProductionLibrary;
using System;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public async void xUnit_Async_Void() =>
            await new TestAsync().Foo(o => Assert.Equal(32, o));

        [Fact]
        public async Task xUnit_Async_Task() =>
            await new TestAsync().Foo(o => Assert.Equal(32, o));
    }
}
