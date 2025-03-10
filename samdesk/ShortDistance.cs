using System;
using System.Collections.Generic;

namespace SamDesk
{
    public class ShortDistance
    {
        public int SolveLists(List<int> leftList, List<int> rightList) {
            int res = 0;
            leftList.Sort();
            rightList.Sort();
            for (int i = 0; i < leftList.Count; i++)
            {
                res += Math.Abs(leftList[i] - rightList[i]);
            }
            return res;
        }
    }
}
