using Leecode.Solutions;
using Xunit;

namespace Leecode.Test
{
    public class DesignHashMapTest
    {
        [Fact]
        public void Test()
        {
            var map = new DesignHashMap();
            map.Put(1, 1);
            map.Put(2, 2);
            var get1 = map.Get(1);
            Assert.Equal(1, get1);
            var get2 = map.Get(3);
            Assert.Equal(-1, get2);
            map.Put(2, 1);
            var get3 = map.Get(2);
            Assert.Equal(1, get3);
            map.Remove(2);
            var get4 = map.Get(2);
            Assert.Equal(-1, get4);
        }
    }
}