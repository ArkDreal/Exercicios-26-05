using System;
namespace Elevador
{
    public abstract class Elevador
    {
        public int AndarAtual = 0;
        public int AndarTotal;
        public int CapacidadeTotal;
        public int PessoasTotal;

        public void Inicializar()
        {
            AndarAtual = 0;
            AndarTotal = 10;
            CapacidadeTotal = 8;
        }

        public int AlterarPessoas()
        {
            Console.WriteLine("Qunatas pessoas você deseja que estejam no elevador");
            PessoasTotal = int.Parse(Console.ReadLine());
            return PessoasTotal;
        }
        
        
        public int AlterarAndar()
        {
            Console.WriteLine("Qual andar você deseja ir?");
            AndarAtual = int.Parse(Console.ReadLine());
            return AndarAtual; 
        }
    }
}