using System;
using Exercicio_2.classes;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque Ja = new JogadorAtaque();
            JogadorMeioCampo Jm = new JogadorMeioCampo();
            JogadorDefesa Jd = new JogadorDefesa();
            bool Invalida = false;

            do
            {


                Console.WriteLine($@"
Qual jogador você deseja?
1 - Jogador Ataque
2 - Jogador Defesa
3 - Jogador Meio-Campo");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Qual o nome do jogador?");
                        Ja.NomeJogador = Console.ReadLine();

                        Console.WriteLine("Qual o ano de nascimento do jogador?");
                        Ja.AnoNasc = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a nacionalidade do jogador?");
                        Ja.Nacionalidade = Console.ReadLine();

                        Console.WriteLine("Qual a altura do jogador?");
                        Ja.AlturaJogador = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o peso do jogador?");
                        Ja.PesoJogador = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{Ja.MostrarInfo()}");
                        Console.WriteLine($"O jogador tem {Ja.CalcularIdade()} anos");
                        Console.WriteLine(Ja.Aposentar());
                        break;

                    case "2":
                        Console.WriteLine("Qual o nome do jogador?");
                        Jd.NomeJogador = Console.ReadLine();

                        Console.WriteLine("Qual o ano de nascimento do jogador?");
                        Jd.AnoNasc = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a nacionalidade do jogador?");
                        Jd.Nacionalidade = Console.ReadLine();

                        Console.WriteLine("Qual a altura do jogador?");
                        Jd.AlturaJogador = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o peso do jogador?");
                        Jd.PesoJogador = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{Jd.MostrarInfo()}");
                        Console.WriteLine($"O jogador tem {Jd.CalcularIdade()} anos de idade");
                        Console.WriteLine(Jd.Aposentar());
                        break;

                    case "3":
                        Console.WriteLine("Qual o nome do jogador?");
                        Jm.NomeJogador = Console.ReadLine();

                        Console.WriteLine("Qual o ano de nascimento do jogador?");
                        Jm.AnoNasc = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual a nacionalidade do jogador?");
                        Jm.Nacionalidade = Console.ReadLine();

                        Console.WriteLine("Qual a altura do jogador?");
                        Jm.AlturaJogador = double.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o peso do jogador?");
                        Jm.PesoJogador = double.Parse(Console.ReadLine());

                        Console.WriteLine($"{Jm.MostrarInfo()}");
                        Console.WriteLine($"O jogador tem {Jm.CalcularIdade()} anos de idade");
                        Console.WriteLine(Jm.Aposentar());
                        break;
                    default:
                        Console.WriteLine("A opção selecionada é inválida, por favor, selecione uma opção válida");
                        Invalida = true;
                        break;
                }
            } while (Invalida);


        }
    }
}