using System;
using System.Collections.Generic;
using System.Text;

namespace FindVowel
{
    public static class FindVowel
    {
        public static char? FirstChar(FindVowelReader reader)
        {
            string vowels = "aeiou";
            bool latestCharWasConsonant = false;
            List<char> vowelsAfterConsonant = new List<char>();
            StringBuilder dataBuilder = new StringBuilder();

            while (reader.HasNext())
            {
                char currentChar = reader.GetNext();
                dataBuilder.Append(currentChar);

                bool isVowel = vowels.IndexOf(currentChar, StringComparison.OrdinalIgnoreCase) >= 0;

                if (isVowel)
                {
                    if (latestCharWasConsonant)
                        vowelsAfterConsonant.Add(currentChar);

                    latestCharWasConsonant = false;
                }
                else
                    latestCharWasConsonant = true;
            }

            string data = dataBuilder.ToString();

            for (int i = 0; i < vowelsAfterConsonant.Count; i++)
            {
                if (data.IndexOf(vowelsAfterConsonant[i].ToString(), StringComparison.OrdinalIgnoreCase) == 
                    data.LastIndexOf(vowelsAfterConsonant[i].ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    return vowelsAfterConsonant[i];
                }
            }

            return null;
        }
    }
}
