namespace Exercicio_2.classes
{
    public class JogadorDefesa : Jogador
    {
        public string Aposentar()
        {
            if (CalcularIdade() < 40)
            {
                TempoRestante = 40 - CalcularIdade();
                return $"O jogador ainda jogará por {TempoRestante} Anos, até ter idade para aposentar";
            }else
            {
                return $"O jogador já tem idade para se aposentar";
            }
        }
    }
}