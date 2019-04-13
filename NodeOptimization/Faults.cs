using System.Collections.Generic;

namespace NodeOptimization
{
    public static class Faults
    {
        public static bool LinkState(string node1, string node2)
        {
            Dictionary<string, int> vals = new Dictionary<string, int>();
            vals.Add("0A", 1);
            vals.Add("AE", 1);
            vals.Add("AC", 1);
            vals.Add("AB", 1);
            vals.Add("BD", 0);
            vals.Add("CD", 1);
            vals.Add("CE", 1);
            return vals[node1 + node2] == 1 ? true : false;
        }
        public static int LinkDistance(string node1, string node2)
        {
            Dictionary<string, int> vals = new Dictionary<string, int>();
            vals.Add("0A", 1);
            vals.Add("AE", 15);
            vals.Add("AC", 4);
            vals.Add("AB", 7);
            vals.Add("BD", 2);
            vals.Add("CD", 11);
            vals.Add("CE", 3);
            return vals[node1 + node2];
        }
    }
}
