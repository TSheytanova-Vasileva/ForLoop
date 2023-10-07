namespace examp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = int.Parse(Console.ReadLine());
            //for (int x = 1; x <= 20; x += 1)
            //{
            //    int square = x * x;
            //    Console.WriteLine($"{x} * {x} = {square}");

            //}
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            for (int i = 0; i < n; i += 1)
            {
                sum += double.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}