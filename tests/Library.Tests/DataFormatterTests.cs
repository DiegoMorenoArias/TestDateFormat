using TestDateFormat;
namespace Library.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestCorrectFormat()
        {
            const string expected = "2004-06-07";
            string testDate = DateFormatter.ChangeFormat("07/06/2004");
            Assert.AreEqual(expected, testDate);
        }
        [Test]
        public void TestIncorrectFormatDate()
        {
            const string expected = "";
            string testDate = DateFormatter.ChangeFormat("2023/09/06");
            Assert.AreEqual (expected, testDate);
        }
        [Test]
        public void TestVoidDate()
        {
            const string expected= "";
            string testDate = DateFormatter.ChangeFormat("");
            Assert.AreEqual (expected, testDate);
        }
    }
}