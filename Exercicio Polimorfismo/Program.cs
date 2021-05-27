using System;
using MaquinaDeCafe.Classes;

namespace Exercicio_Polimorfismo
{
     class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            CafeComAcucar ca = new CafeComAcucar();
            
            int AcucarDisponivel = 50;
            
            do
            {
                

                Console.WriteLine($@"
Seja bem-vindo ao painel da Mega Cafeteira Badaras
O estoque de açucar está em {AcucarDisponivel}
1 - Fazer café com açucar
3 - Fazer café sem açucar");
                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        ca.FazerCafe(1);
                        Console.WriteLine($"O seu café foi feito com {ca.Acucar}mg de açucar! Aproveite");
                        AcucarDisponivel = AcucarDisponivel - ca.Acucar;
                    
                        break;

                    case "3":
                        m.FazerCafe("Sem açucar");
                        break;
                    default:
                        Console.WriteLine("A opção digitada é invalida, tente novamente");
                        break;
                }

                if (AcucarDisponivel <= 0)
                {
                    Console.WriteLine("O açucar disponível no depósito acabou! :(");
                }
            } while (AcucarDisponivel > 0);

        }
    }
}
