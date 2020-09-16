using Course;
using System;
using System.Globalization;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto p = new Produto("TV", 500.00, 10);

            //(p.GetQuantidade = -10;) - Se não fosse colocado o encapsulamento(private) nos atributos da classe PRODUTO o usuário poderia utilizar esse código livremente para alterar a quantidade em estoque do produto sem precisar utilizar o método ADICIONARPRODUTO ou GetQUANTIDADE.
            p.AdicionarProdutos(35); //Com o encapsulamento apenas utilizando os métodos definidos para conseguir alterar a quantidade em estoque.
            p.RemoverProdutos(25);

            Console.Write("Quantidade em estoque: " + p.GetQuantidade());
            Console.WriteLine();
        }
    }
}
