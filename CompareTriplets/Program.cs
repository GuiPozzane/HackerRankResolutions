using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareTriplets
{
    public class Program
    {
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            var resultado = new List<int>() { 0, 0};
            
            for (int i = 0; i < 3; i++)
            {
                if (a[i] > b[i])
                    resultado[0] += 1; 
                else if (a[i] < b[i])
                    resultado[1] += 1;
            }
            return resultado;
        }

        static void Main(string[] args)
        {


            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            List<int> result = CompareTriplets(a, b);

            Console.WriteLine(result.ArrayToText2Positions());
            


        }
    }

}
public static class ExtendedArray
{
    public static string ArrayToText2Positions(this List<int> array)
    {
        return $"[{array[0]}, {array[1]}]";
    }
}