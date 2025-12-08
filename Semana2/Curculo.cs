// clase
public class Circulo: Figura
{
    // atributos
    public double Radio { get;  set; }
    
    // constructor
    public Circulo(double Radio)
    {
        this.Radio = Radio;
    }

    // metodos
    public override double CalcularArea()
    {
        return Math.PI * this.Radio * this.Radio;
    }

    public override double CalcularPerimetro()
    {
        return 0;
    }
}