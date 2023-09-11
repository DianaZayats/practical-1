using System;
using System.Collections.Generic;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        int sequenceLength = 5;

        int[] randomNumbers = new int[sequenceLength];

        using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
        {
            byte[] randomBytes = new byte[4];

            for (int i = 0; i < sequenceLength; i++)
            {
                rng.GetBytes(randomBytes);
                int randomNumber = BitConverter.ToInt32(randomBytes, 0);
                randomNumbers[i] = randomNumber;
            }
        }

        Console.WriteLine("Послідовність криптографічно стійких випадкових цілих чисел:");
        Console.WriteLine(string.Join(", ", randomNumbers));
    }
}