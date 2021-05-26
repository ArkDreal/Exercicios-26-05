using System;
using Elevador.Classes;
namespace Exercicio_1
{
 class Program
    {
        static string RespostaCaixas;
        static bool Repeticao = true;
        static void Main(string[] args)
        {
            ElevadorServico so = new ElevadorServico();
            ElevadorServico se = new ElevadorServico();

            Console.WriteLine("Qual elevador você deseja entrar? 1- Serviço / 2 - Social ");
            string Resposta = Console.ReadLine().ToUpper();

            switch (Resposta)
            {
                case "1":

                    so.Inicializar();
                    do
                    {
                        Console.WriteLine($@"
Você está no {se.AndarAtual}°, há {se.PessoasTotal} pessoas no elevador, há {se.Caixas} caixas. O que você deseja fazer?
2 - Alterar Andar
3 - Alterar quantidade de caixas
4 - Alterar quantidade de pessoas
5 - Finalizar");
                        string opcao = Console.ReadLine();
                        switch (opcao)
                        {


                            case "2":
                                so.AlterarAndar();
                                break;

                            case "3":           
                                    se.AlterarCaixas();
                                    Console.WriteLine($"A quantidade de caixas é de {se.Caixas}");                                
                                break;
                            case "4":
                                do
                                {
                                    so.AlterarPessoas();
                                    if (so.PessoasTotal > 8)
                                    {
                                        Console.WriteLine($"Há mais pessoas do que a capacidade máxima, a capacidade é de {so.CapacidadeTotal}");
                                    }
                                } while (so.PessoasTotal > 8);
                                break;

                            case "5":
                                Console.WriteLine("Tenha um bom dia!!");
                                Repeticao = false;
                                break;

                            default:
                                Console.WriteLine("Houve um erro, por favor, use uma ação válida");
                                break;
                        }
                    } while (Repeticao);
                    break;

                case "2":
                    so.Inicializar();
                    do
                    {
                        Console.WriteLine($@"
Você está no {so.AndarAtual}°, há {so.PessoasTotal} pessoas no elevador. O que você deseja fazer?
2 - Alterar Andar
4 - Alterar quantidade de pessoas
5 - Finalizar");
                        string opcao = Console.ReadLine();
                        switch (opcao)
                        {


                            case "2":
                                so.AlterarAndar();
                                break;


                            case "4":
                                do
                                {
                                    so.AlterarPessoas();
                                    if (so.PessoasTotal > 8)
                                    {
                                        Console.WriteLine($"Há mais pessoas do que a capacidade máxima, a capacidade é de {so.CapacidadeTotal}");
                                    }
                                } while (so.PessoasTotal > 8);
                                break;

                            case "5":
                                Console.WriteLine("Tenha um bom dia!!");
                                Repeticao = false;
                                break;

                            default:
                                Console.WriteLine("Houve um erro, por favor, use uma ação válida");
                                break;
                        }
                    } while (Repeticao);
                    break;
                default:
                    break;
            }

        }
    }
}
