namespace Ex11;

public class Circulo
{
    
    public double Raio { get; set; }
    
    public double CalcularArea() {
        return Math.PI * Raio * Raio;
    }
    
   
}