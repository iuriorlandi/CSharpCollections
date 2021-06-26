using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack
{
    internal class Navegador
    {
        private readonly Stack <string> _historicoAnterior = new();
        private readonly Stack<string> _historicoPosterior = new();
        private string _paginaAtual;

        public Navegador()
        {
            _paginaAtual = "HomePage";
            ImprimirPaginaAtual();
        }

        internal void NavegarPara(string url)
        {
            _historicoAnterior.Push(_paginaAtual); 
            _paginaAtual = url;
            ImprimirPaginaAtual();
        }

        internal void Proxima()
        {
            NavegarHistorico(_historicoAnterior, _historicoPosterior);
        }

        private void NavegarHistorico(Stack<string> pilhaOrigem, Stack<string> pilhaDestino)
        {
            if (!pilhaDestino.Any())
                return;

            pilhaOrigem.Push(_paginaAtual);
            _paginaAtual = pilhaDestino.Pop();
            ImprimirPaginaAtual();

        }

        internal void Anterior()
        {
            NavegarHistorico(_historicoPosterior, _historicoAnterior);
        }

        private void ImprimirPaginaAtual()
        {
            Console.WriteLine(_paginaAtual);
        }
    }
}