using System;
public abstract class Veiculo
{
    private double TaxaDiaria { get; set; }

    // inicia a taxa diária
    protected Veiculo(double taxaDiaria)
    {
        TaxaDiaria = taxaDiaria;
    }

    // calcular o valor total
    public abstract double CalcularValorTotal(int numDiarias);

    // taxa diária nas classes herdeiras
    protected double GetTaxaDiaria()
    {
        return TaxaDiaria;
    }
}

public class Carro : Veiculo
{
    // recebe a taxa diária como parâmetro
    public Carro() : base(50.0) { }
l
    public override double CalcularValorTotal(int numDiarias)
    {
        return GetTaxaDiaria() * numDiarias;
    }
}

public class Moto : Veiculo
{
    // recebe a taxa diária como parâmetro
    public Moto() : base(25.0) { }

    public override double CalcularValorTotal(int numDiarias)
    {
        return GetTaxaDiaria() * numDiarias;
    }
}

// Classe principal para testar a implementação
class Program
{
    static void Main()
    {
        Carro carro = new Carro();
        Moto moto = new Moto();

        int diarias = 10;
        Console.WriteLine($"Valor total da locação do carro para {diarias} diárias: R$ {carro.CalcularValorTotal(diarias)}");
        Console.WriteLine($"Valor total da locação da moto para {diarias} diárias: R$ {moto.CalcularValorTotal(diarias)}");
    }
}