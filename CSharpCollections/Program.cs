using System;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] aulas = new string[3];

            var aula1 = "Introdução.";
            var aula2 = "Conteúdo.";
            var aula3 = "Exercícios.";

            aulas[0] = aula1;
            aulas[1] = aula2;
            aulas[2] = aula3;

            string[] copiaComTamanhoDois = new string[2];

            Array.Copy(aulas, 0, copiaComTamanhoDois, 0, 2);

            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }

            foreach (var aula in copiaComTamanhoDois)
            {
                Console.WriteLine(aula);
            }

        }
    }
}
