//Daniel Hiroshi Fugikawa - 200209
using System.Globalization;


namespace ConsoleApp3
{
    public class produto
    {
        //Declaração das variaveis do produto
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Declaração do construtor
        public produto (string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Contrutor vazio
        public produto()
        {

        }

        //Função para calcular o valor total do estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Função para adicionar Produtos ao estoque
        public void AdicionarProduto(int qtd)
        {
            Quantidade += qtd;
        }

        //Função para remover produtos do estoque
        public void RemoverProduto(int qtd)
        {
            Quantidade = Quantidade - qtd;
        }

        //Criando um formato para o ToString
        public override string ToString()
        {
            return Nome
            + ",R$"
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ","
            + Quantidade
            +" unidades,Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
    
}
