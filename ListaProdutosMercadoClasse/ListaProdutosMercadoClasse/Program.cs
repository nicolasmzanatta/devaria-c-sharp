using System;
using System.Collections.Generic;
using System.Linq;
using ListaProdutosMercadoClasse.Classes;    //importando o namespace

namespace ListaProdutosMercadoClasse
{
    class Program
    {

        /*
         
        ​Escrever um programa -ok
        Que recebe alguns produtos como argumento -ok
        E validar se esse produtos estão na lista de itens disponíveis do mercado. -ok

        Caso estejam, avisar o usuário quais produtos estão disponíveis -ok
        
        e quais não estão e, por último,

        exibir a lista de produtos disponíveis ordenados por ordem alfabética do mercado, para que o usuário possa pedir na próxima vez.


        */
        static void Main(string[] argumentos)
        {
            List<Produto> produtosDisponiveis = new List<Produto>();   //cada vez q da um new ta criando um objeto na memoria
            produtosDisponiveis.Add(new Produto() { Nome = "Pão", Preco = 0.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Shampoo", Preco = 19.9 });
            produtosDisponiveis.Add(new Produto() { Nome = "Azeite", Preco = 14.5 });
            produtosDisponiveis.Add(new Produto() { Nome = "Refrigerante", Preco = 6.25 });
            produtosDisponiveis.Add(new Produto() { Nome = "Queijo", Preco = 12.75 });
            produtosDisponiveis.Add(new Produto() { Nome = "Carne", Preco = 62.80 });


            if (argumentos.Length == 0)
            {
                Console.WriteLine("Você não passou os produtos que deseja comprar");
                return;
            }

            var produtosSelecionadosDisponiveis = produtosDisponiveis.Where(produto => argumentos.Any(argumento => produto.Nome.ToUpper() == argumento.ToUpper()));   //Any: se tem algum argumento valido 

            foreach(var produto in produtosSelecionadosDisponiveis)
            {
                Console.WriteLine($"Este produto nós temos: {produto.ExibirDadosProdutos()}");
            }

            var produtosSelecionadosNaoDisponiveis = argumentos.Where(argumento => !produtosDisponiveis.Any(produto => produto.Nome.ToUpper() == argumento.ToUpper())); //aq tem q partir dos argumentos, pq quer ver de la quais nao estao disponiveis

            foreach (var produtoNaoDisponivel in produtosSelecionadosNaoDisponiveis)
            {
                Console.WriteLine($"Este produto nós não temos infelizmente =/ {produtoNaoDisponivel}");
            }

            var produtoOrdenadosPorNome = produtosDisponiveis.OrderBy(produto => produto.Nome).ToList();

            foreach(var produtoOrdenado in produtoOrdenadosPorNome)
            {
                Console.WriteLine(produtoOrdenado.ExibirDadosProdutos());
            }
        }
    }
}
