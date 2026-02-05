using System;

namespace SimpleMathTasks
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("1. Calculate a^n");
      Console.WriteLine("2. Transform number x to n");
      Console.Write("Choose task (1 or 2): ");
      
      string choice = Console.ReadLine();
      
      if (choice == "1")
      {
        CalculatePower();
      }
      else if (choice == "2")
      {
        TransformNumber();
      }
      else
      {
        Console.WriteLine("Invalid choice");
      }
    }
    
    static void CalculatePower()
    {
      Console.Write("Enter base (a): ");
      int a = int.Parse(Console.ReadLine());
      
      Console.Write("Enter exponent (n): ");
      int n = int.Parse(Console.ReadLine());
      
      int result = 1;
      for (int i = 0; i < n; i++)
      {
        result *= a;
      }
      
      Console.WriteLine($"{a}^{n} = {result}");
    }
    
    static void TransformNumber()
    {
      Console.Write("Enter number x (>= 100): ");
      string x = Console.ReadLine();
      
      if (x.Length < 3)
      {
        Console.WriteLine("Number must have at least 3 digits");
        return;
      }
      
      char secondDigit = x[1];
      string withoutSecondDigit = x.Remove(1, 1);
      string n = withoutSecondDigit + secondDigit;
      
      Console.WriteLine($"x = {x}");
      Console.WriteLine($"n = {n}");
    }
  }
}
