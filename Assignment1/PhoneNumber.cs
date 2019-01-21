using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class PhoneNumber : IFormatter
    {
        private int areaCode;
        private int exchangePrefix;
        private int phoneNumber;
        private string formattedPhoneNumber;

        public PhoneNumber(string input)
        {
            areaCode = int.Parse(input.Substring(0, 3));
            exchangePrefix = int.Parse(input.Substring(3, 3));
            phoneNumber = int.Parse(input.Substring(6, 4));
            formattedPhoneNumber = null;
        }

        public void Format()
        {
            formattedPhoneNumber = $"({areaCode}) {exchangePrefix}-{phoneNumber}";
        }

        public override string ToString()
        {
            if (formattedPhoneNumber == null)
            {
                Format();
            }

            return formattedPhoneNumber;
        }
    }
}
