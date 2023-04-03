namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = CreateArray();
            FillArray(arr);
            Console.WriteLine();
            int maxSum=0;
            for (int i = 0; i < arr.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    sum += arr[i][j];
                }
                Console.WriteLine($"{1+i}st row`s sum: {sum}");
                if(maxSum<sum)
                {
                    maxSum= sum;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Max summ in rows: {maxSum}");
        }
        public static int[][] CreateArray()
        {
            Random random = new Random();
            int[][] array1 = new int[random.Next(1,10)][];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new int[random.Next(1, 10)];
            }
            return array1;
        }
        public static void FillArray(int[][] array1) 
        {
            Random random = new Random();
            CreateArray();
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array1[i].Length; j++)
                {
                    array1[i][j] = random.Next(1, 10);
                    Console.Write($" {array1[i][j]}");
                }
                Console.WriteLine();
            }
        }
    }
}