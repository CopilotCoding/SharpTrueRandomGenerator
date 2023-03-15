namespace TrueRandom
{
    using System.Security.Cryptography;
    using System.Text;
    using static System.Console;

    internal class Program
    {
        static void Main(string[] args)
        {       
            WriteLine("Enter the amount of bytes to use in the random number, the number will be larger with more bytes: ");
            WriteLine();

            String? userInputNumber = ReadLine();
            Int32 amountOfBytes = Convert.ToInt32(userInputNumber);

            WriteLine();
            WriteLine(TrueRandomNumber(amountOfBytes));
            WriteLine();
            WriteLine();
            WriteLine();

            Main(args);
        }

        static String TrueRandomNumber(Int32 sizeOfRandomNumberInBytes)
        {
            StringBuilder sb = new StringBuilder();
            RandomNumberGenerator r = RandomNumberGenerator.Create();

            Byte[] bytes = new Byte[sizeOfRandomNumberInBytes];

            r.GetBytes(bytes);

            foreach (Byte b in bytes)
            {
                sb.Append(b);
            }

            return sb.ToString();
        }
    }
}
