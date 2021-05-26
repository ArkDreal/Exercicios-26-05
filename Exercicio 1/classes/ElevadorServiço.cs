using System;
namespace Elevador.Classes
{
    public class ElevadorServico : Elevador
    {
        public int Caixas;

        public int AlterarCaixas()
        {
            Console.WriteLine("Quantas caixas você deseja colocar no elevador?");
            Caixas = int.Parse(Console.ReadLine());
    
            return Caixas;
        }
    }
}