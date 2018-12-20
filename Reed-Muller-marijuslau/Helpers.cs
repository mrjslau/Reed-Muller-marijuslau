using System.Text.RegularExpressions;

namespace Reed_Muller_marijuslau
{
    static class Helpers
    {
        public static bool CheckParams(string m, string r, string q, string vector)
        {
            return (Regex.IsMatch(m, @"^\d+$") && Regex.IsMatch(r, @"^\d+$") &&
                    Regex.IsMatch(q, @"-?\d+(?:\.\d+)?") && Regex.IsMatch(vector, @"^\d+$"));
        }
    }
}
