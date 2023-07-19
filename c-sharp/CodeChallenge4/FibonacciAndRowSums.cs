namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static void Main(string[] args)
    {
      try
      {
        int n;
        do
        {
          Console.WriteLine("Welcome to Fibonacci's! What can we getcha? Positive Whole Numbers ONLY");
          n = int.Parse(Console.ReadLine());
          Console.WriteLine($"{GetNthNumberInFibonacciSequence(n)} is the nth Fib value where n = {n}");
        }while (n > 0);
      }
      catch (Exception e)
      {
        Console.WriteLine("You goofed! BEGONE!");
      }
      
    }
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      int result = 0;
      result += Fib(nthNumberInSequence);
      //Fib(5) = Fib(4) + Fib(3)
      //8 = 5 + 3
      return result;
    }
    public static int Fib(int n)
    {
      if (n < 2)
      {
        //Console.WriteLine($"F{n} is {n}");
        switch (n)
        {
          case 0:
            n = 0;
            return n;
          case 1:
            n = 1;
            return n;
        }
      }
      int nmo = Fib(n - 1);
      int nmt = Fib(n - 2);
      int result = nmo + nmt;

      //Console.WriteLine($"F{n} is {result}");

      return result;
        

    }

    public static int[] RowSums(int[][] matrix)
    {
      int[] rowSums = new int[matrix[0].Length];
      return rowSums;
    }

  }
}
