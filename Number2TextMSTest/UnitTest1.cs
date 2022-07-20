namespace Number2TextMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodConvert1()
        {
            //
            Assert.AreEqual("ноль", new Number2Text.Number2Text().Corvert(0));
        }

        [TestMethod]
        public void TestMethodConvert2()
        {
            //
            Assert.AreEqual("десять", new Number2Text.Number2Text().Corvert(10));
        }

        [TestMethod]
        public void TestMethodConvert3()
        {
            //
            Assert.AreEqual("сто одиннадцать", new Number2Text.Number2Text().Corvert(111));
        }

        [TestMethod]
        public void TestMethodConvert4()
        {
            //
            Assert.AreEqual("одна тысяча одиннадцать", new Number2Text.Number2Text().Corvert(1011));
        }
    }
}