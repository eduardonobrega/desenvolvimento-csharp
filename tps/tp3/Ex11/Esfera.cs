namespace Ex11;

public class Esfera
{
    public double Raio { get; set; }
    
    public double CalcularVolume() {
        return 4.0 / 3.0 * Math.PI * Raio * Raio * Raio;
    }
}