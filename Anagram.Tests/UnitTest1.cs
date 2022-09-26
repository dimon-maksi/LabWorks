namespace Anagram.Tests
{
    public class AnagramTests
    {
        [Theory]
        [InlineData("", "")]
        [InlineData("test sentence", "tset ecnetnes")]
        [InlineData(" spec1f1c # d@ta  ", " cfce1p1s # a@td  ")]
        public void TestReverse(string sentence, string expected)
        {
            string actual = LabWork6.Anagram.Reverse(sentence);

            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("", "")]
        [InlineData("qwerty", "ytrewq")]
        [InlineData("$peC1f1c", "$cfC1e1p")]
        public void TestReverseWord(string word, string expected)
        {
            string actual = LabWork6.Anagram.ReverseWord(word);

            Assert.Equal(expected, actual);
        }
    }
}