namespace Massives
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            increaseNumber(n);
        }
        public static void increaseNumber(int n)
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
            int temp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i] > array1[j])
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }
            }
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write($" {array1[i]}");
            }
        }
    }
}