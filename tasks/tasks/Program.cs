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
            Console.Write($"k: ");
            int k = int.Parse(Console.ReadLine());
            int[][] arr = new int[m][];
            int l = k-1;
            if(l>=0 && l<m)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = new int[n];
                    for (int j = 0; j < arr[i].Length; j++)
                    {
                        arr[i][j] = random.Next(1, 10);
                        Console.Write($" {arr[i][j]}");
                    }
                    Console.WriteLine();
                }
                int sum = 0;
                int multiply = 1;
                for (int j = 0; j < n; j++)
                {
                    for (int i = 0; i < m; i++)
                    {
                        if(l==j)
                        {
                            sum += arr[i][j];
                            multiply *= arr[i][j];
                        }
                    }
                }
                Console.WriteLine($"sum in column k: {sum}");
                Console.WriteLine($"multiply in column k: {multiply}");
            }
        }
    }
}