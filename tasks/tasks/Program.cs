namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write($"m: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write($"n: ");
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[m][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[n];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(1, 100);
                    Console.Write($" {arr[i][j]}");
                }
                Console.WriteLine();
            }
            int maxN = arr[0][0];
            int minN = arr[0][0];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (maxN < arr[i][j])
                    {
                        maxN = arr[i][j];
                    }
                    if (minN > arr[i][j])
                    {
                        minN = arr[i][j];
                    }
                }
            }
            Console.WriteLine($"Max number: {maxN}");
            Console.WriteLine($"Min number: {minN}");
        }
    }
}