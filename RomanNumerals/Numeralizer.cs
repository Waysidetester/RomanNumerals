using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace RomanNumerals
{
    public class Numeralizer
    {
        string[] singles = new string[] { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        string[] tens = new string[] { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC", "C" };
        string[] hundreds = new string[] { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM", "M" };
        string[] thousands = new string[] { "M", "MM", "MMM" };
        public string RomanNumEquv(string numberInput)
        {
            try
            {

                var srgToNumber = numberInput
                    .ToCharArray()
                    .Reverse()
                    .ToArray();

                string[] RomanString = new string[srgToNumber.Length];

                for (int i = 0; i < numberInput.Length; i++)
                {
                    var selectedNum = Convert.ToInt32(srgToNumber[i].ToString());
                    if(selectedNum != 0)
                    {
                        if (i == 0)
                        {
                            RomanString[i] = singles[selectedNum-1];
                        }
                        else if (i == 1)
                        {
                            RomanString[i] = tens[selectedNum - 1];
                        }
                        else if (i == 2)
                        {
                            RomanString[i] = hundreds[selectedNum - 1];
                        }
                        else if (i == 3)
                        {
                            RomanString[i] = thousands[selectedNum - 1];
                        }
                    }
                }


                var result = RomanString.Reverse().ToArray();
                return string.Join(string.Empty, result);
            }
            catch(IndexOutOfRangeException)
            {
                throw new NumberTooLargeException();
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
