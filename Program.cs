namespace CodeWars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DoubleChar("Double?"));
        }
        /*
         * Task: Given a string, you have to return a string in which each character (case-sensitive) is repeated once.
         * Code turns input string to a array of chars. Then adds every index to a new string twice.
         */
        public static string DoubleChar(string s)
        {
            char[] stringAsChars = s.ToCharArray();

            string newString = "";

            foreach (char c in stringAsChars)
            {
                newString += c;
                newString += c;
            }
            return newString;            
        }

        /*Checks if input integer is a prime number by dividing with all
         * integers from 2 until the input number is reached (if input is 1, return is false) 
         * If the input number is divided by any number without a remainder return is false,
         * else return is true.
         */
        public static bool IsPrime(int n)
        {
            if (n == 1) return false;
            int i = 2;
            while (i != n)
            {
                if (n % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}