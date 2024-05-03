using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio04
{
    public class Produto
    {
        private string nome = "";
        private double preco;
        private int quantidadeEmEstoque;

        public void setNome(string nome) {
            this.nome = nome;
        }   

        public string getNome() {
            return this.nome;
        }

        public void setPreco(double preco){
            this.preco = preco;
        }

        public double getPreco() {
            return this.preco;
        }
        
        public void setQuantidadeEmEstoque(int quantidadeEmEstoque) {
            this.quantidadeEmEstoque = quantidadeEmEstoque;
        }

        public int getQuantidadeEmEstoque() {
            return this.quantidadeEmEstoque;
        }

        public void adicionarEstoque(int quantidade){
            this.quantidadeEmEstoque += quantidade;
        }

        public void removerEstoque(int quantidade){
            this.quantidadeEmEstoque -= quantidade;
        }

        public double valorEstoque(){
            return this.quantidadeEmEstoque * this.preco;
        }
    }
}