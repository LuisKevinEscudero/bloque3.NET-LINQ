/*Given a non-empty string consisting only of special chars (!, @, # etc.), return a number (as a string) where each digit corresponds to given special char on the keyboard ( 1→ !, 2 → @, 3 → # etc.).
Expected input and output
"())(" → "9009"
"*$(#&" → "84937"
"!!!!!!!!!!" → "1111111111"*/

namespace DecryptNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new char[] { ')', '!', '@', '#', '$', '%', '^', '&', '*', '(' };

            var encryptedNumber = "#(@*%)$(&$*#&";

            var query = from c in encryptedNumber
                        select Array.IndexOf(chars, c);

            Console.WriteLine(string.Join("", query));



        }
    }
}














/* static void Main(string[] args)
        {
            Console.WriteLine(DecryptNumber("())("));
            Console.WriteLine(DecryptNumber("*$(#&"));
            Console.WriteLine(DecryptNumber("!!!!!!!!!!"));
        }

        static string DecryptNumber(string input)
        {
            string output = "";
            foreach (char c in input)
            {
                output += (int)c - 33;
            }
            return output;
        }*/