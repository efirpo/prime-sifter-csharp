using System;
using System.Collections.Generic;
using PrimeSifter.Method;

namespace PrimeSifter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter your number: ");
      int userNumber = int.Parse(Console.ReadLine());
      List<int> primeArray = PrimeSifter.Method.IsPrime.IsItPrime(userNumber);
      foreach (int number in primeArray)
      {
        Console.WriteLine(number);
      }
    }
  }
}
