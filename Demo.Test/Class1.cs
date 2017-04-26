using Xunit;

namespace Demo.Test
{
    public class Class1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        [Fact]
        public void PassingTest2()
        {
            Assert.Equal(4, Add(3, 1));
        }

        [Fact]
        public void PassingTest3()
        {
            Assert.Equal(4, Add(1, 2));
        }

        [Fact]
        public void PassingTest4()
        {
            Assert.Equal(8, Add(1,7));
        }

        //[Fact]
        //public void FailingTest()
        //{
        //    Assert.Equal(5, Add(2, 2));
        //}

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}
