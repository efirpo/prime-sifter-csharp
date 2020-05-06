using System;
using System.Collections.Generic;

namespace PrimeSifter.Method
{
  public class IsPrime
  {
    public static List<int> IsItPrime(int number)
    {
      List<int> PrimeNumbers = new List<int>(0);

      for (int i = 2; i <= number; i++)
      {
        PrimeNumbers.Add(i);
      }

      int prime = 2;
      while (prime < PrimeNumbers[-1])
      {
        foreach (int num in PrimeNumbers)
        {
          if (num % prime == 0 && num != prime)
          {
            PrimeNumbers.Remove(num);
            Console.WriteLine("remove check!");
          }
          Console.WriteLine("prime: " + prime);
        }
        prime += 1;
      }
      return PrimeNumbers;

      // int x = 0;
      // for (int i = 1; i < PrimeNumbers.Count; i++)
      // {
      //   int n = PrimeNumbers[x];
      //   Console.WriteLine("i at start: " + i);
      //   Console.WriteLine("n at loop start: " + n);
      //   if (PrimeNumbers[i] % n == 0)
      //   {
      //     PrimeNumbers.RemoveAt(i);
      //     Console.WriteLine("inner n: " + n);

      //   }
      //   x += 1;
      //   Console.WriteLine("x after if: " + x);
      // }
      // return PrimeNumbers;


      // int x = 0;
      // while ()
      // {
      //   for (int i = 1; i < PrimeNumbers.Count; i++)
      //   {
      //     int n = PrimeNumbers[x];
      //     if (PrimeNumbers[i] % n == 0)
      //     {
      //       PrimeNumbers.Remove(i);
      //       Console.WriteLine("infinity and beyond?");
      //       Console.WriteLine("inner n: " + n);
      //     }
      //     x += 1;
      //   }
      //   break;
      // }
      // return PrimeNumbers;
      // int prime = 2;
      // for (int i = 1; i <= PrimeNumbers.Count; i++)
      // {

      //   if (PrimeNumbers[i] % prime == 0)
      //   {
      //     PrimeNumbers.RemoveAt(i);
      //   }
      //   prime += 1;
      // }
      // return PrimeNumbers;
    }
  }
}