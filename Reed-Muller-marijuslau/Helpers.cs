using System.Text.RegularExpressions;

namespace Reed_Muller_marijuslau
{
    static class Helpers
    {
        // Tikrinami parametrai m, r, q ir bitu eilute, kurie ivedami 'MainForm' formoje
        public static bool CheckParams(string m, string r, string q, string vector)
        {
            return (Regex.IsMatch(m, @"^\d+$") && Regex.IsMatch(r, @"^\d+$") &&
                    Regex.IsMatch(q, @"-?\d+(?:\.\d+)?") && Regex.IsMatch(vector, @"^\d+$"));
        }
    }
}
