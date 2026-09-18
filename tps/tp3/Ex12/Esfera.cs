namespace Ex12;

public class Esfera
{
    public double Raio { get; private set; }

    public Esfera(double raio)
    {
        Raio = raio;
    }
    
    public double CalcularVolume() {
        return 4.0 / 3.0 * Math.PI * Raio * Raio * Raio;
    }
}