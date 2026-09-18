namespace Ex12;

public class Circulo
{
    
    public double Raio { get; private set; }

    public Circulo(double raio)
    {
        Raio = raio;
    }
    
    public double CalcularArea() {
        return Math.PI * Raio * Raio;
    }
    
   
}