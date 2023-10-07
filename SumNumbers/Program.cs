namespace SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double sum = 0;

            for ( int i =1; i <= num; i +=1)
            {
                double number = double.Parse(Console.ReadLine());
                sum = sum + number;

            }
            Console.WriteLine(sum);
        }
    }
}