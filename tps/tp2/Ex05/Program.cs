namespace Ex05;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Temperatura em Celsius: ");
        var celsius = double.Parse(Console.ReadLine());
        
        double f = celsius * 9/5 + 32;
        double k = celsius + 273.15;
        
        Console.WriteLine(f.ToString("F2") + " °F");
        Console.WriteLine(k.ToString("F2") + " K");

    }
}