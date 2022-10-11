using System;

namespace Open_Lab_04._04
{
    public class PhoneNumbers
    {
        public string FormatPhoneNumber(int[] numbers)
        {
            var phone123 = string.Concat(numbers[0..3]);
            var phone456 = string.Concat(numbers[3..6]);
            var phone78910 = string.Concat(numbers[6..]);
            return new string($"({phone123}) {phone456}-{phone78910}");
        }
    }
}
