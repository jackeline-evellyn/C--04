using System;
using System.Globalization;

namespace _4_SegundoProblema
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.Write("Dados do produto: "+p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);
           
            //remover
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: "+p);
            Console.WriteLine("");
            Console.Write("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a serem removidos no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }

    }
}
