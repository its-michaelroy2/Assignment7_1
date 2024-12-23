namespace Assignment7_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assignment 7.1.1 & 7.1.2");
            Console.WriteLine("===============\n");

            string result1 = MergeStrings("abc", "pqr");
            Console.WriteLine($"Output 1: {result1}");

            string result2 = MergeStrings("ab", "pqrs");
            Console.WriteLine($"Output 2: {result2}");
        }

        static string MergeStrings(string word1, string word2)
        {
            string mergedString = "";
            int maxLength = Math.Max(word1.Length, word2.Length);

            for (int i = 0; i < maxLength; i++)
            {
                if (i < word1.Length)
                    mergedString += word1[i];
                if (i < word2.Length)
                    mergedString += word2[i];
            }

            return mergedString;
        }
    }
}