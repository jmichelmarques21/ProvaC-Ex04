using System.Runtime.CompilerServices;
using Exercicio04;

public class Program {
  public static void Main(string[] args) {
    
    Produto produto = new Produto();

    produto.setNome("Vinho");
    string nome = produto.getNome();
    produto.setPreco(60.90);
    double preco = produto.getPreco();
    produto.setQuantidadeEmEstoque(5);
    int quantidadeEmEstoque = produto.getQuantidadeEmEstoque();

    double valorTotal = produto.valorEstoque();
    System.Console.WriteLine("Valor total em estoque: R$" + valorTotal);


  }
}