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
      // while()
      // {
      //     foreach(int num in PrimeNumbers){
      //     if ()
      //   }
      // }
      int prime = 2;
      for (int i = PrimeNumbers.IndexOf(prime) + 1; i <= PrimeNumbers.Count; i++)
      {

        if (PrimeNumbers[i] % prime == 0)
        {
          PrimeNumbers.RemoveAt(i);
        }
        prime += 1;
      }
      return PrimeNumbers;
    }
  }
}