namespace FirstNNumbersSum
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 1;
            Console.Write(1);

            for ( int i = 2; i <= num; i++)
            {
                 
                Console.Write( "+" + i);
                 sum += i;

            }
            Console.WriteLine("=" + sum );


        }
    }
}