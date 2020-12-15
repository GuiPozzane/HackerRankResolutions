using System;
using System.Linq;
using System.IO;

namespace SimpleArraySum
{
    public class Program
    {
        public static int SimpleArraySum(int[] ar) => ar.Sum(x => x);
       

        public static void Main(string[] args)
        {

            int arCount = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = SimpleArraySum(ar);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
