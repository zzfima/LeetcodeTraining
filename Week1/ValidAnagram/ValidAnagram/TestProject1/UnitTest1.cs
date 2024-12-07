using ValidAnagram;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Algo algo = new Algo();
            bool expected = true;
            bool actual = algo.IsAnagramUsingTwoDictionaries("anagram", "nagaram");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Algo algo = new Algo();
            bool expected = false;
            bool actual = algo.IsAnagramUsingTwoDictionaries("rat", "car");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Algo algo = new Algo();
            bool expected = true;
            bool actual = algo.IsAnagramUsingTwoCarArrays("anagram", "nagaram");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Algo algo = new Algo();
            bool expected = false;
            bool actual = algo.IsAnagramUsingTwoCarArrays("rat", "car");
            Assert.AreEqual(expected, actual);
        }
    }
}