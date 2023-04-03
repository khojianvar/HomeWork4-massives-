namespace Massives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!"); Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Enter l: ");
            int l = int.Parse(Console.ReadLine());
            changeKandL(n,k,l);
        }
        public static void changeKandL(int n, int k, int l)
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
            array1[k] = array1[k] + array1[l];
            array1[l] = array1[k] - array1[l];
            array1[k] = array1[k] - array1[l];
            Console.WriteLine($"After: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{array1[i]} ");
            }
        }

    }
}