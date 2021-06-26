using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var navegador = new Navegador();

            navegador.NavegarPara("google.com");
            navegador.NavegarPara("alura.com");
            navegador.NavegarPara("youtube.com");

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();

            navegador.Proxima();
            navegador.Proxima();

            navegador.Anterior();
            navegador.Anterior();
            navegador.Anterior();
        }
    }
}
