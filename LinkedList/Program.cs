using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var dias = new LinkedList<string>();

            var d1 = dias.AddFirst("Domingo");

            var d7 = dias.AddLast("Sábado.");

            var d2 = dias.AddAfter(d1, "Segunda");
            var d3 = dias.AddAfter(d2, "Terça");
            dias.AddAfter(d3, "Quarta");

            var d6 = dias.AddBefore(d7, "Sexta");
            dias.AddBefore(d6, "Quinta");
            
            Imprimir(dias);
        }

        private static void Imprimir(LinkedList<string> dias)
        {
            foreach (var dia in dias)
            {
                System.Console.WriteLine(dia);
            }
        }
    }
}
