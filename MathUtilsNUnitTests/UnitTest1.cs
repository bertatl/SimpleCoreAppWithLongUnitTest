using MathUtils;

namespace MathUtilsNUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Add()
        {
            var mu = new Utils();
            var res = mu.Add(1, 1);
            Assert.That(2, Is.EqualTo(res));
        }

        [Test]
        public void Long_Test()
        {
            System.Threading.Thread.Sleep(660000);
            Assert.Pass();
        }
    }
}
