using System;

class Acao
{
    public string pregao, codAcao, ordem;
    public double preco;
    public int qtd;

    public void coletarDadosAcao()
    {
        Console.WriteLine("Pregão:");
        pregao = Console.ReadLine();
        
        Console.WriteLine("Código da Ação:");
        codAcao = Console.ReadLine();
        
        Console.WriteLine("Compra/Venda:");
        ordem = Console.ReadLine();
        
        Console.WriteLine("Quantidade:");
        qtd = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Preço:");
        preco = Convert.ToDouble(Console.ReadLine());  
    }
}
