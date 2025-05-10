using System;

public abstract class Veiculo
{
    protected double TaxaDiaria { get; set; }
    public Veiculo(double taxa) => TaxaDiaria = taxa;
    public abstract double CalcularValorTotal(int numDiarias);
}

public class Carro : Veiculo
{
    public Carro() : base(50.0) { }
    public override double CalcularValorTotal(int numDiarias) => TaxaDiaria * numDiarias;
}

public class Moto : Veiculo
{
    public Moto() : base(25.0) { }
    public override double CalcularValorTotal(int numDiarias) => TaxaDiaria * numDiarias;
}

class Program
{
    static void Main()
    {
        Veiculo carro = new Carro();
        Veiculo moto = new Moto();
        int diarias = 10;
        Console.WriteLine($"Carro ({diarias} diárias): R$ {carro.CalcularValorTotal(diarias)}");
        Console.WriteLine($"Moto ({diarias} diárias): R$ {moto.CalcularValorTotal(diarias)}");
    }
}
