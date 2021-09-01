using System;
using System.Threading.Tasks;

namespace ProductionLibrary
{
    public class TestAsync
    {
        public async Task<string> Foo(Action<int> a)
        {
            await Task.Delay(30);
            a(42);
            return "foo";
        }

        public string Bar() => "bar";

        public void ThrowStuff() => throw new ArgumentException("x");
    }
}
