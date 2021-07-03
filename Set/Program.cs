using System;
using System.Collections.Generic;

namespace Set
{
    class Program
    {
        static void Main(string[] args)
        {
            ISet<string> alunos = new HashSet<string>();

            alunos.Add("João");
            alunos.Add("Bianca");
            alunos.Add("Carlos");

            Console.WriteLine(string.Join(",", alunos));

            alunos.Add("Patricia");
            alunos.Add("Luiz");
            alunos.Add("Pedro");

            Console.WriteLine(string.Join(",", alunos));
        }
    }
}
