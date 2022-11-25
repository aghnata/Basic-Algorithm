using System;
using System.Collections.Generic;
using System.Linq;

namespace Persiapan_Xtremax
{
    class Program
    {
        static void Main(string[] args)
        {
            //var items = new List<string> { "Node1", "Node2", "Node3" };

            //string output = BuildRecursionTree("", items, 0);

            //// Result: Node1 <- Node2 <- Node3 <-.
            //Console.Write(output);


            //var factorial = new Factorial();
            //var hasilFactorial = factorial.Result(4);
            //Console.WriteLine(hasilFactorial);

            //var primeNumber = new PrimeNumber();
            //primeNumber.Print(3);


            //var reverseNumber = new ReverseNumber();
            //reverseNumber.Result(12345678);

            //var palindrome = new Palindrome();
            //Console.WriteLine(palindrome.IsPalindrome("asaasa"));

            var checkLevelPalindrome = new Palindrome();
            Console.WriteLine(checkLevelPalindrome.CheckLevelPalindrome2("asa iasa"));

            //var buyGame = new BuyGame();
            //var aa = buyGame.ge

            List<int> studentsMoney = new List<int> { 3500, 9800, 7700, 2000, 700, 6900, 7100, 5200, 4100, 7300 };
            var studentsFriend = new List<List<int>>();

            studentsFriend.Add(new List<int> { 3, 5, 6, 7, 9 });
            studentsFriend.Add(new List<int> { 4, 6 });
            studentsFriend.Add(new List<int> { 2, 5, 6, 7, 8, 9 });
            studentsFriend.Add(new List<int> { 2, 3, 5, 9 });
            studentsFriend.Add(new List<int> { 0, 2, 3, 4, 6, 9 });
            studentsFriend.Add(new List<int> { 0, 1, 2 });
            studentsFriend.Add(new List<int> { 0, 5, 6, 8, 9 });

            studentsFriend.Add(new List<int> { 0, 1, 3, 6, 7 });
            studentsFriend.Add(new List<int> { 0, 1, 4, 5, 7, 8 });
            
            int gamePrice = 7000;

            var res = new List<int>();

            for (int i = 0; i < studentsMoney.Count(); i++)
            {
                if (studentsMoney.ElementAt(i) >= gamePrice)
                {
                    var listFriend = studentsFriend.ElementAt(i);
                    int countRichFriend = 0;
                    foreach (var item in listFriend)
                    {
                        if (studentsMoney.ElementAt(item) >= gamePrice)
                        {
                            countRichFriend += 1;
                        }
                    }
                    if (!res.Contains(i) && countRichFriend >= 2)
                    {
                        res.Add(i);
                    }
                }
            }


            var aa = res;


        }

        //static string BuildRecursionTree(string value, List<string> items, int index)
        //{
        //    // "index" variable value checking helps call recursive function finite number of times.
        //    if (items.Count == index)
        //    {
        //        return value;
        //    }

        //    // Add node.
        //    value += " " + items[index] + " <-";

        //    // Actual recursion: call function itself once more time.
        //    return BuildRecursionTree(value, items, index + 1);
        //}
    }
}
