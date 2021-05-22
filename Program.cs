using System;
using System.Collections.Generic;
using System.Linq;

namespace listaMercado
{
    class Program
    {

        /*
        > Escrever um programa que receba alguns produtos como argumento; <OK>
        > validar se os produtos estão na lista de ítens disponíveis no mercado; <Ok>
        > avisar ao usuário quis itens estão disponíveis ou não;
        > Exibir uma lista de produtos dispiníveis em ordem alfabética para o usuário possa pedir da próxima vez.
        */

        static void Main(string[] argumentos)
        {
            // criar a lista de produtos do mercado
            List<string> produtosDisponiveis = new List<string>()
            {
                "pao", "leite", "macarrão", "carne", "massa de tomate", "refrigerante", "alface", "tomate"
            };

            // Validar se os argumentos foram preenchidos
            try
            {
                //listar quais produtos tem no mercado
               var produtosSelecionados = produtosDisponiveis.Where(produto => argumentos.Contains(produto)).ToList();
               foreach(var produtosSelecionado in produtosSelecionados)
               {
                   Console.WriteLine($"este produto nós temos: {produtosSelecionado }");
               }

                //lista de produtos que não tem no mercado
                var produtosNaoDisponiveis = argumentos.Where(argumentos => !produtosDisponiveis.Contains(argumentos)).ToList();
                foreach(var produtoNaoDisponivel in produtosNaoDisponiveis)
                {
                    Console.WriteLine($"este produto infelizmente nós não temos: {produtoNaoDisponivel}");
                }

                // retornar uma lista em ordem alfabética
                var produtosDisponiveisOrdenadosPorNome = produtosDisponiveis.OrderBy(e => e).ToList();
                foreach(var produtoOrdenado in produtosDisponiveisOrdenadosPorNome)
                {
                    Console.WriteLine($"segue este produto disponível: {produtoOrdenado}");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Argumentos inválidos");
            }

        }
    }
}
