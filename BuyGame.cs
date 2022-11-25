using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Persiapan_Xtremax
{
    public class BuyGame
    {
        public static List<int> getBuyers(List<int> studentsMoney, List<List<int>> studentsFriend, int gamePrice)
        {
            var res = new List<int>();

            for (int i = 0; i < studentsMoney.Count() ; i++)
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


            return res ;

        }
    }
}
