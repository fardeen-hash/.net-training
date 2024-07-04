public class Program
{
    public static void Main()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1,2));
        Console.WriteLine(calculator.Add(1,2,3));
        Console.WriteLine(calculator.Add(new int[]{1,2,3,4,69}));



    }
}