using System.Text;
using System.Text.RegularExpressions;
using NCalc;

namespace Lab1_2;

public static class Calculator
{
    public static string Calculate(string str)
    {
        Regex nums = new Regex(@"\d+");
        StringBuilder sb = new StringBuilder(str);
        //Regex rgx = new Regex(@"\(\d+([+*/-]\d+)*\)");
        List<string> xds = new List<string>();
        xds = nums.Matches(str).Cast<Match>().Select(m => m.Value).ToList();

        foreach (var m in xds)
        {
            sb.Replace(m, Convert.ToInt32(m, 2).ToString());
        }

        return Convert.ToString((int)new Expression(sb.ToString()).Evaluate(), 2);
    }
}