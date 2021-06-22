using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            var aula1 = "Introdução.";
            var aula2 = "Conteúdo.";
            var aula3 = "Exercícios.";

            List<string> listaAulas = new List<string> { aula1, aula2, aula3 };

            Imprimir(listaAulas); 
        }

        private static void Imprimir(List<string> listaAulas)
        {
            listaAulas.ForEach(aula =>
            {
                System.Console.WriteLine(aula);
            });
        }
    }
}
