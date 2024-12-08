
namespace ValidAnagram
{
    public class Algo
    {
        public bool IsAnagramUsingTwoDictionaries(string sourceString, string targetString)
        {
            Dictionary<char, int> sourceLettersFrequency = GenerateLettersFrequencyDict(sourceString);
            Dictionary<char, int> targetLettersFrequency = GenerateLettersFrequencyDict(targetString);

            if (sourceLettersFrequency.Count != targetLettersFrequency.Count)
                return false;

            foreach (var letterFrequency in sourceLettersFrequency)
            {
                //there is no letter
                if (!targetLettersFrequency.ContainsKey(letterFrequency.Key))
                    return false;

                //letter frequency is different
                if (targetLettersFrequency[letterFrequency.Key] != letterFrequency.Value)
                    return false;
            }
            return true;
        }

        private Dictionary<char, int> GenerateLettersFrequencyDict(string sourceString)
        {
            Dictionary<char, int> lettersFrequencyDict = new Dictionary<char, int>();

            foreach (char letter in sourceString)
            {
                if (!lettersFrequencyDict.ContainsKey(letter))
                    lettersFrequencyDict.Add(letter, 0);

                lettersFrequencyDict[letter]++;
            }


            return lettersFrequencyDict;
        }

        public bool IsAnagramUsingTwoCarArrays(string sourceString, string targetString)
        {
            char[] sourceChars = sourceString.ToCharArray();
            char[] targetChars = targetString.ToCharArray();

            Array.Sort(sourceChars);
            Array.Sort(targetChars);

            return new String(sourceChars) == new String(targetChars);
        }
    }
}
