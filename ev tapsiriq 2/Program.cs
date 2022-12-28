namespace ev_tapsiriq_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ededi daxil edin");
            int e = int.Parse(Console.ReadLine());

            int a, b, c, d, s;
            a = 2345 / 1000;
            b = 34 / 10;
            c = 234%10;
            d = 2345 % 10;
            s = 1 * a + 2 * b + 3 * c + 4 * d;
            Console.WriteLine(s);
        }
    }
}