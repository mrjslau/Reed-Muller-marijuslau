using System;

namespace Reed_Muller_marijuslau
{
    static class Channel
    {
        public static string Transmit(string bitString, double q)
        {
            char[] messageChars = bitString.ToCharArray();
            Random rand = new Random();

            for (int i = 0; i < messageChars.Length; i++)
                if (q > rand.NextDouble()) messageChars[i] = SwitchBits(messageChars[i]);

            return new string(messageChars);
        }

        static char SwitchBits(char c)
        {
            return (c == '0') ? '1' : '0';
        }
    }
}
