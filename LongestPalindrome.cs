namespace LongestPalidrome
{
    using System;
    public class LongestPalindrome
    {
        private static void GetLongestPalindrome(String str)
        {
            int maximumLength = 1;

            int start = 0;
            int len = str.Length;

            int first, last;

            for (int i = 1; i < len; ++i)
            {
                first = i - 1;
                last = i;
                while (first >= 0 && last < len && str[first] == str[last])
                {
                    if (last - first + 1 > maximumLength)
                    {
                        start = first;
                        maximumLength = last - first + 1;
                    }
                    --first;
                    ++last;
                }

                first = i - 1;
                last = i + 1;
                while (first >= 0 && last < len && str[first] == str[last])
                {
                    if (last - first + 1 > maximumLength)
                    {
                        start = first;
                        maximumLength = last - first + 1;
                    }
                    --first;
                    ++last;
                }
            }
            first = start;
            last = start + maximumLength - 1;
            Console.Write("Input String: {0} \nOutput String: ", str);
            for (int i = first; i <= last; ++i)
                Console.Write(str[i]);
            Console.Write("\n");
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Input String to obtain the longest palindrome");
            string input = Console.ReadLine();
            if (input.Length > 0)
            {
                LongestPalindrome.GetLongestPalindrome(input);
            }
            else
            {
                Console.Write("Invalid Input");
            }
        }
    }
}
