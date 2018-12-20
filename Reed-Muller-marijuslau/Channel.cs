using System;

namespace Reed_Muller_marijuslau
{
    static class Channel
    {
        // Siuntimo kanalu funkcija, kurioje random objekto pagalba
        // pagal duotą tikimybę sukeliamas triukšmas kanale.
        public static string Transmit(string bitString, double q)
        {
            char[] messageChars = bitString.ToCharArray();
            Random rand = new Random();

            for (int i = 0; i < messageChars.Length; i++)
                if (q > rand.NextDouble()) messageChars[i] = SwitchBits(messageChars[i]);

            return new string(messageChars);
        }

        // Bitų sukeitimas
        static char SwitchBits(char c)
        {
            return (c == '0') ? '1' : '0';
        }
    }
}
