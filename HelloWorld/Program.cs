namespace HelloWorld;

public class Program
{
    static void Main(string[] args)
    {
        int[] numbers = [1, 2, 3];

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int a = 1;
        int b = 2;
        int c = Add(a, b);

        Console.WriteLine($"{a} + {b} = {c}");

        Console.WriteLine("Hello, World!");
    }

    public static int Add(int a, int b)
    {
        return a + b;
    }
}
