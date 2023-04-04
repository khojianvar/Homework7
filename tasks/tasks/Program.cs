namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write($"row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write($"column: ");
            int column = int.Parse(Console.ReadLine());
            Console.Write($"k: ");
            int k = int.Parse(Console.ReadLine());
            int[][] arr = new int[row][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[column];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(1, 5);
                    Console.Write($" {arr[i][j]}");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (k == arr[i][j])
                    {
                        if (k == arr[0][0])
                        {
                            continue;
                        }
                        if (k == arr[i][0])
                        {
                            arr[i - 1][arr[i].Length - 1] = 0;
                        }
                        else
                        {
                            arr[i][j - 1] = 0;
                        }
                    }
                }
            }
            Console.WriteLine("After: ");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write($" {arr[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}