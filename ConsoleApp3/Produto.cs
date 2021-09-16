//Daniel Hiroshi Fugikawa - 200209
using System.Globalization;


namespace ConsoleApp3
{
    public class produto
    {
        //Declaração das variaveis do produto
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Declaração do construtor
        public produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //contrutor padrao
        public produto()
        {

        }

      public string Nome
        {
            get { return _nome; }
            set { if(value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

       public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        //Função para calcular o valor total do estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        //Função para adicionar Produtos ao estoque
        public void AdicionarProduto(int qtd)
        {
            _quantidade += qtd;
        }

        //Função para remover produtos do estoque
        public void RemoverProduto(int qtd)
        {
            _quantidade = _quantidade - qtd;
        }

        //Criando um formato para o ToString
        public override string ToString()
        {
            return _nome
            + ",R$"
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ","
            + _quantidade
            + " unidades,Total: R$"
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }

}
