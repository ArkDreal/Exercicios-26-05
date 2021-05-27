using System;
namespace MaquinaDeCafe.Classes
{
    public class CafeComAcucar : MaquinaCafe
    {
        public int FazerCafe(int AcucarPadrao)
        {          
            Console.WriteLine("Quantos gramas de açucar você deseja em seu café? Para utilizar a medida padrão, digite 0");         
            Acucar = int.Parse(Console.ReadLine());
            if (Acucar == 0)
            {
                Acucar = 10;
            }

            return Acucar;
        }
    }
}