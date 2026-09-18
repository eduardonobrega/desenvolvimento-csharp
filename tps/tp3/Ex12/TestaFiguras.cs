namespace Ex12;

class TestaFiguras
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo(3);
        Esfera esfera = new Esfera(5);
        
        Console.WriteLine($" Circulo de raio: {circulo.Raio} | Area: {circulo.CalcularArea():F2}");
        Console.WriteLine($" Esfera de raio: {esfera.Raio} | Area: {esfera.CalcularVolume():F2}");
    }
}