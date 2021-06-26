using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> pedagio = new();

            Enfileirar("Carro", pedagio);
            Enfileirar("Caminhão", pedagio);
            Enfileirar("Onibus", pedagio);
            Enfileirar("Carreta", pedagio);

            Desenfileirar(pedagio);
            Desenfileirar(pedagio);
            Desenfileirar(pedagio);
            Desenfileirar(pedagio);

        }

        private static void Desenfileirar(Queue<string> pedagio)
        {
            if (!pedagio.Any())
                return;

            var veiculo = pedagio.Dequeue();
            
            Console.WriteLine();
            Console.WriteLine($"{veiculo} saiu da fila!");

            ImprimirFila(pedagio);
        }

        private static void Enfileirar(string veiculo, Queue<string> pedagio)
        {
            pedagio.Enqueue(veiculo);

            Console.WriteLine();
            Console.WriteLine($"{veiculo} entrou na fila!");
            
            ImprimirFila(pedagio);
        }

        private static void ImprimirFila(Queue<string> pedagio)
        {
            
            Console.WriteLine("Fila:");
            foreach (var veiculo in pedagio)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}
