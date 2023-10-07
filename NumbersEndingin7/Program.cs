namespace NumbersEndingin7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for ( int i =7; i<= num; i += 1 )
            {
                if ( i % 10 == 7)
                {
                    Console.WriteLine( i );
                }
            }
        }
    }
}