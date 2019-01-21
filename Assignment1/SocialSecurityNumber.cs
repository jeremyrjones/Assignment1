using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1
{
    class SocialSecurityNumber : IFormatter
    {
        private int groupOne;
        private int groupTwo;
        private int groupThree;
        private string formattedSsn;

        public SocialSecurityNumber(string input)
        {
            groupOne = int.Parse(input.Substring(0, 3));
            groupTwo = int.Parse(input.Substring(3, 2));
            groupThree = int.Parse(input.Substring(5, 4));
            formattedSsn = null;
        }

        public void Format()
        {
            formattedSsn = $"{groupOne}-{groupTwo}-{groupThree}";
        }

        public override string ToString()
        {
            if (formattedSsn == null)
            {
                Format();
            }

            return formattedSsn;
        }
    }
}
