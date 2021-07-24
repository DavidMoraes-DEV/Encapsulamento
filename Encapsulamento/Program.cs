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
/*O QUE É ENCAPSULAMENTO?

- É um princípio que consiste em esconder detalhes de implementação de um componente, expondo apenas operações seguras
e que o mantenha em um estado consistente.

- Regra de Ouro: O objeto deve sempre estar em um estado consistente, e a própria classe deve garantir isso.
 */