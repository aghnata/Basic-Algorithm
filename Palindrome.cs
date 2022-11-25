using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persiapan_Xtremax
{
    class Palindrome
    {
        public static bool IsPalindrome(string text)
        {
            var dd = text;
            if (text.Length <= 1)
                return true;
            else
            {
                if (text[0] != text[text.Length - 1])
                    return false;
                else
                {
                    string get = text.Substring(1, text.Length - 2);

                    return IsPalindrome(get);
                }
            }
        }

        public int CheckLevelPalindrome(string text)
        {

            int res = 0;
            string tmp = "";

            var textForeach = text.ToLower().Where(x => !Char.IsWhiteSpace(x)) ;

            //foreach (var item in textForeach)
            //{
            //    tmp += item;
            //    if (IsPalindrome(tmp) && tmp.Length > 1)
            //    {
            //        res += 1;
            //    }
            //}

            for (int i = textForeach.Count()/2; i < textForeach.Count() ; i++)
            {
                tmp += textForeach.ElementAt(i) ;
                if (IsPalindrome(tmp) && tmp.Length > 1)
                {
                    res += 1;
                }
            }

            return res;
        }

        public int CheckLevelPalindrome2(string text)
        {
            int res = 0;

            var textForeach = text.ToLower().Where(x => !Char.IsWhiteSpace(x));

            for (int i = textForeach.Count(); i > 1; i /= 2 )
            {
                string tmp = "";

                for (int j = 0; j < i; j++)
                {
                    tmp += textForeach.ElementAt(j);
                }
                var dd = "";
                if (IsPalindrome(tmp) && tmp.Length > 1)
                {
                    res += 1;
                }
            }

            return res;
        }


    }
}
