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
        return Round(Math.PI * this.Radio * this.Radio, 2);
    }

    public override double CalcularPerimetro()
    {
        return 0;
    }
}

using System;

class Programa
{
    static void Main()
    {
        // La circunferencia es una figura geométrica que tiene un radio.
        // El perímetro (o longitud) se calcula con la fórmula: 2 * π * radio.

        Console.WriteLine("Cálculo del perímetro de una circunferencia");
        Console.Write("Ingrese el valor del radio: ");

        // Leer el radio ingresado por el usuario
        double radio = double.Parse(Console.ReadLine());

        // Calcular el perímetro usando la fórmula 2 * PI * radio
        double perimetro = 2 * Math.PI * radio;

        // Mostrar el resultado en pantalla
        Console.WriteLine("El perímetro de la circunferencia es: " + perimetro);
    }
}
