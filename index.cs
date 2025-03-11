class Calculator
{
    static void Main(String[] args)
    {
        int a = 10;
        int b = 6;

        Console.WriteLine("Penambahan {0} + {1} = {2}", a, b, Penambahan(a));
        Console.WriteLine("Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a));
    }

    static int Penambahan(int a, int b)
    {
        return a + b;
    }

    static int Pengurangan(int a, int b)
    {
        return a - b;
    }
}