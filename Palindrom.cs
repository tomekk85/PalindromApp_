using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PalindromApp
{
    public class Palindrom
    {
        private String word;

        public Palindrom(string word) 
        {
            this.word = word;
        }
        public Boolean IsPalindrom() 
        {
            string input_ = Regex.Replace(this.word, @"\s", "");
            input_ = input_.ToLower();
            char[] charArray = input_.ToCharArray();
            Array.Reverse(charArray);
            string reversed_ = new string(charArray);

            return input_.Equals(reversed_);
        }
    }
}
