using System;
namespace Exercicio_2.classes
{
    public abstract class Jogador
    {
        public string NomeJogador;
        public int AnoNasc;
        public int TempoRestante;
        public string Nacionalidade;
        public double AlturaJogador;
        public int IdadeJogador;
        public double PesoJogador;

        public string MostrarInfo()
        {
            return $@"
Informações do jogador
Nome: {NomeJogador}
Ano de Nascimento: {AnoNasc}
Nacionalidade: {Nacionalidade}
Altura: {AlturaJogador}
Peso: {PesoJogador}";
        }

        public int CalcularIdade()
        {
            return IdadeJogador = (DateTime.Now.Year - AnoNasc);
        }
    }
}