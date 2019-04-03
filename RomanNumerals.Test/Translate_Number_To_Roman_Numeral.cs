using System;
using Xunit;

namespace RomanNumerals.Test
{
    public class Translate_Number_To_Roman_Numeral
    {
        [Fact]
        public void Number_1_is_I()
        {
            var engine = new Numeralizer();
            var input = "1";
            var expectedResult = "I";

            string result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_5_is_V()
        {
            var engine = new Numeralizer();
            var input = "5";
            var expectedResult = "V";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_9_is_IX()
        {
            var engine = new Numeralizer();
            var input = "9";
            var expectedResult = "IX";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_12_is_XII()
        {
            var engine = new Numeralizer();
            var input = "12";
            var expectedResult = "XII";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_16_is_XVI()
        {
            var engine = new Numeralizer();
            var input = "16";
            var expectedResult = "XVI";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_29_is_XXIX()
        {
            var engine = new Numeralizer();
            var input = "29";
            var expectedResult = "XXIX";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_44_is_XLIV()
        {
            var engine = new Numeralizer();
            var input = "44";
            var expectedResult = "XLIV";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_45_is_XLV()
        {
            var engine = new Numeralizer();
            var input = "45";
            var expectedResult = "XLV";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_68_is_LXVIII()
        {
            var engine = new Numeralizer();
            var input = "68";
            var expectedResult = "LXVIII";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_83_is_LXXXIII()
        {
            var engine = new Numeralizer();
            var input = "83";
            var expectedResult = "LXXXIII";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_97_is_XCVII()
        {
            var engine = new Numeralizer();
            var input = "97";
            var expectedResult = "XCVII";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_99_is_XCIX()
        {
            var engine = new Numeralizer();
            var input = "99";
            var expectedResult = "XCIX";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_500_is_D()
        {
            var engine = new Numeralizer();
            var input = "500";
            var expectedResult = "D";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_501_is_DI()
        {
            var engine = new Numeralizer();
            var input = "501";
            var expectedResult = "DI";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_649_is_DCXLIX()
        {
            var engine = new Numeralizer();
            var input = "649";
            var expectedResult = "DCXLIX";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

        [Fact]
        public void Number_798_is_DCCXCVIII()
        {
            var engine = new Numeralizer();
            var input = "798";
            var expectedResult = "DCCXCVIII";

            var result = engine.RomanNumEquv(input);

            Assert.Equal(expectedResult, result);
        }

    }
}
