using System;
using System.Collections.Generic;
using System.ComponentModel;

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
        public int TaskDay2(List<List<int>> reports)
        {
            int res = 0;
            foreach (List<int> list in reports)
            {
                int direction = 0;
                for (int i=1; i<list.Count; i++)
                {
                    if (list[i - 1] == list[i]) {
                        res -= 1;
                        break;
                    }
                    if (list[i - 1] > list[i])
                    {
                        if ((list[i - 1] - list[i]) <= 3 && direction >= 0)
                        {
                            if (direction == 0) { direction = 1; }
                        }
                        else
                        {
                            res -= 1;
                            break;
                        }
                    }
                    else
                    if (list[i - 1] < list[i])
                    {
                        if ((list[i] - list[i - 1]) <= 3 && direction <= 0)
                        {
                            if (direction == 0) { direction = -1; }
                        }
                        else
                        {
                            res -= 1;
                            break;
                        }
                    }
                }
                res += 1;
            }
            return res;
        }

    }
}
