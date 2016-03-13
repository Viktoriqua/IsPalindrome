using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPalindrome
{
    public class CheckPalindrome
    {
        private static bool IsDelimeter(char symbol)
        {
            string delimeters = " ,?./<>!/n/t()*&^%$+=-_;:";
            return delimeters.Contains(symbol);
        }

        public static bool IsPalindrome(string theString)
        {
            if (theString == String.Empty)
            {
                throw new ArgumentNullException("theString");
            }

            theString = theString.ToUpper();
            int leftPos = 0;
            int rightPos = theString.Length - 1;

            while (leftPos < rightPos)
            {
                while (IsDelimeter(theString[leftPos]) && leftPos < rightPos)
                {
                    leftPos++;
                }
                while (IsDelimeter(theString[rightPos]) && rightPos > leftPos)
                {
                    rightPos--;
                }
                if (theString[leftPos] != theString[rightPos])
                {
                    return false;
                }
                leftPos++;
                rightPos--;
            }
            return true;
        }

    }
}