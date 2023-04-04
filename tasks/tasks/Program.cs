namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.Write("Array`s row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Array`s column: ");
            int column = int.Parse(Console.ReadLine());
            int[][] array1 = new int[row][];
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = new int[column];
                for (int j = 0; j < array1[i].Length; j++)
                {
                    array1[i][j] = random.Next(1, 6);
                    Console.Write($" {array1[i][j]}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Result:");
            Summ(array1);
            
        }
        public static void Summ(int[][] array )
        {
            int sum;
            for (int i = 0; i < array.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum+= array[i][j];
                }
                Console.Write($"{sum} ");
            }
        }
    }
}