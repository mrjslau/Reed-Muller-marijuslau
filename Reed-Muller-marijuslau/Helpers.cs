using System;
using System.Text.RegularExpressions;

namespace Reed_Muller_marijuslau
{
    static class Helpers
    {
        // Tikrinami parametrai m, r, q ir bitu eilute, kurie ivedami 'MainForm' formoje
        public static bool CheckParams(string m, string r, string q, string vector)
        {
            return (Regex.IsMatch(m, @"^\d+$") && Regex.IsMatch(r, @"^\d+$") &&
                    Regex.IsMatch(q, @"-?\d+(?:\.\d+)?") && Regex.IsMatch(vector, @"^\d+$") &&
                    CheckIfBiggerOrEql(m, r) && BetweenOneAndZero(q));
        }

        public static bool CheckIfBiggerOrEql(string m, string r)
        {
            return Convert.ToInt32(m) >= Convert.ToInt32(r);
        }

        public static bool BetweenOneAndZero(string q)
        {
            return Convert.ToDouble(q) >= 0.0 && Convert.ToDouble(q) <= 1.0;
        }
    }
}
