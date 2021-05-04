using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaDeProdutosDisponiveis
{
    class Program
    {
        /*
        ​Escrever um programa que recebe alguns produtos como argumento, validar se esses produtos estão na lista de itens disponíveis do mercado.
        ​Caso estejam, avisar o usuário quais produtos tem e quais não tem e, por último, exibir a lista de produtos disponíveis
        ordenados por ordem alfabética do mercado, para que o usuário possa pedir na próxima vez.
        */

        static void Main(string[] args)
        {
            //lista de produtos q o mercado tem 
            List<string> produtosDisponiveis = new List<string>()
           {
               "pão", "leite", "manteiga", "requeijão", "refrigerante", "arroz", "alface", "tomate", "frango", "doce"
           };

            //validar se os argumentos foram preenchidos 
            try
            {
                //listar quais produtos informados do argumento tem na lista do mercado
                var produtosSelecionados = produtosDisponiveis.Where(produto => args.Contains(produto)).ToList(); //to list transformou de volta em lista
                foreach (var produtoSelecionado in produtosSelecionados)   // apos o to.list, o foreach serviu para percorrer a lista
                {
                    Console.WriteLine($"Este produto nós temos: {produtoSelecionado}");
                }

                //listar os produtos informados que nao tem no mercado 
                var produtosNaoDisponiveis = args.Where(args => !produtosDisponiveis.Contains(args)).ToList();
                foreach (var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"Este produto nós não temos infelizmente: {produtoNaoDisponivel}");
                }

                //retornar a lista dos prod disponíveis no mercado em ordem alfabetica 
                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(e => e).ToList();
                foreach(var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"Segue este produto disponível: {produtoOrdenado}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            }

        }
    }
}
