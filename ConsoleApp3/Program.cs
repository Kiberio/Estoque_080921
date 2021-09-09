//Daniel Hiroshi Fugikawa - 200209
using System;
using System.Globalization;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar o as informações do produto 
            Console.WriteLine("Entre com os dados do produto");
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            //Declaração de variavel de classe
            produto p = new produto(nome, preco, quantidade);
           
            //Imprimir os dados do estoque
            Console.WriteLine("Dados do produto: " + p);

            //Solicitando o número de produto ao qual o usuario deseja adicionar ao estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);

            //Imprimir os dados atualizados do estoque
            Console.WriteLine("Dados atualizados: " + p);

            //Solicitar o número de produtos ao qual o usuario deseja retirar do estoque
            Console.WriteLine("Digite o número de produtos a ser retirado do estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            //Imprimmir os dados atualizados do estoque 
            Console.WriteLine("Dados atualizados: " + p);

        }
    }
}
