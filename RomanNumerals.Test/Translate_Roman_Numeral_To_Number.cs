using Xunit;

namespace RomanNumerals.Test
{
    public class Translate_Roman_Numeral_To_Number
    {
        [Theory]
        [InlineData("I",1)]
        [InlineData("V", 5)]
        [InlineData("IX", 9)]
        [InlineData("XII", 12)]
        [InlineData("XVI", 16)]
        [InlineData("XXIX", 29)]
        [InlineData("XLIV", 44)]
        [InlineData("XLV", 45)]
        [InlineData("LXVIII", 68)]
        [InlineData("LXXXIII", 83)]
        [InlineData("XCVII", 97)]
        [InlineData("XCIX", 99)]
        [InlineData("D", 500)]
        [InlineData("DI", 501)]
        [InlineData("DCXLIX", 649)]
        [InlineData("DCCXCVIII", 798)]
        [InlineData("DCCCXCI", 891)]
        [InlineData("M", 1000)]
        [InlineData("MIV", 1004)]
        [InlineData("MVI", 1006)]
        [InlineData("MXXIII", 1023)]
        [InlineData("MMXIV", 2014)]
        [InlineData("MMMCMXCIX", 3999)]
        public void Numeral_I_Is_1(string input, int expectedResult)
        {
            var engine = new Numeralizer();

            int result = engine.NormalNumEquiv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Numeral_V_Is_5()
        {
            var engine = new Numeralizer();
            var input = "V";
            var expectedResult = 5;

            int result = engine.NormalNumEquiv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Numeral_IX_Is_9()
        {
            var engine = new Numeralizer();
            var input = "IX";
            var expectedResult = 9;

            int result = engine.NormalNumEquiv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Numeral_XII_Is_12()
        {
            var engine = new Numeralizer();
            var input = "XII";
            var expectedResult = 12;

            int result = engine.NormalNumEquiv(input);

            Assert.Equal(expectedResult, result);
        }

    }
}
