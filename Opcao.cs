using System;

class Opcao
{
    public string pregao, codOpcao, codAcao, tipo, ordem;
    public double strike, preco;
    public int qtd;

    public void coletarDadosOpcao()
    {
        Console.WriteLine("Pregão:");
        pregao = Console.ReadLine();
        
        Console.WriteLine("Código da Opção:");
        codOpcao =  Console.ReadLine();
        
        Console.WriteLine("Código da Ação:");
        codAcao = Console.ReadLine();
        
        Console.WriteLine("Strike:");
        strike = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Call/Put:");
        tipo = Console.ReadLine();
        
        Console.WriteLine("Compra/Venda:");
        ordem = Console.ReadLine();
        
        Console.WriteLine("Quantidade:");
        qtd = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Preço:");
        preco = Convert.ToDouble(Console.ReadLine());  
    }
}
