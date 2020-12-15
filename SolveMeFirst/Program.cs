using System;

namespace SolveMeFirst
{
    public class Program
    {
        public static int SolveMeFirst(int a, int b)
        {
            // Hint: Type return a+b; below  
            return a+b;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = SolveMeFirst(val1, val2);
            Console.WriteLine($"Resultado: {sum}");
            Console.ReadLine();
        }
    }
}
