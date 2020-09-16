using System.Globalization;
namespace Course
{
    class Produto
    {
        private string _nome; //Esse modelo de Encapsulamento consiste em esconder os detalhes de implementação dos componentes do sistema, expondo apenas oerações seguras e que o mantenha em um estado consistente.
        private double _preco; //Todo atributo é definido como priveate, para não poder ser acessado e modificado por outra classe do programa, sendo só possível alterar pelos métodos definidos.
        private int _quantidade;
        //REGRA DE OURO: O objeto(componente) deve sempre estar em um estado consistente, e a própria classe deve garantir isso.
        public Produto()
        {
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        //Implementa-se métodos GET e SET para cada atributo, conforme regras de negócio.
        //OBS. não é usual na plataforma C#, pois podemos utilizar as properts ou PROPRIEDADES para realizar esse feito de forma direta e resumida.
        //Esses métodos abaixo é apenas didático para aprendizado do conceito.
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}