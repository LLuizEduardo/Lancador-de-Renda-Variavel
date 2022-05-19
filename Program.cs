using System;
using System.IO;
using System.Globalization;


namespace Gravar_Opcoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;

            Console.WriteLine("1-opção  //  2-ação");
            int a = Convert.ToInt32(Console.ReadLine());


            if(a < 2)
            {
                string filePath = (@"C:\Users\Luiz Eduardo\iCloudDrive\_Base Dados\opcoes\"+ date.ToString("yyyyMMdd HHmmss") +".txt");
            
                Opcao op = new Opcao();
                op.coletarDadosOpcao();
                string linha = (op.pregao+";"+op.codOpcao+";"+op.codAcao+";"+op.tipo+";"+op.ordem+";"+op.strike+";"+op.preco+";"+op.qtd);

                File.WriteAllTextAsync(filePath, linha.ToUpper());
            }
            else
            {
                string filePath = (@"C:\Users\Luiz Eduardo\iCloudDrive\_Base Dados\acoes\"+ date.ToString("yyyyMMdd HHmmss") +".txt");
            
                Acao ac = new Acao();
                ac.coletarDadosAcao();
                string linha = (ac.pregao+";"+ac.codAcao+";"+ac.ordem+";"+ac.preco+";"+ac.qtd);
           
                File.WriteAllTextAsync(filePath, linha.ToUpper());
            }       
        }
    }
}
