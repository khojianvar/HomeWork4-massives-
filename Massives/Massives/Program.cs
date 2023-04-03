namespace Massives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            haveKorNot(n, k);
        }
        public static void haveKorNot(int n, int k)
        {
            Random random = new Random();
            int[] array1 = new int[n];
            Console.WriteLine($"Before: ");
            for (int i = 0; i < n; i++)
            {
                array1[i] = random.Next(1, 10);
                Console.Write($"{array1[i]} ");
            }
            Console.WriteLine();
            Console.WriteLine($"After: ");
            for (int i = 0; i < n; i++)
            {
                if (array1[i] == k)
                {
                    Console.WriteLine("We have k in array :)");
                    break;
                }
            }
            Console.WriteLine("We have not K in array :(");
        }
    }
}