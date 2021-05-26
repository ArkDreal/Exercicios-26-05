namespace Exercicio_2.classes
{
    public class JogadorMeioCampo : Jogador
    {
        public string Aposentar()
        {
            if (CalcularIdade() < 38)
            {
                TempoRestante = 38 - CalcularIdade();
                return $"O jogador ainda jogará por {TempoRestante} Anos, até ter idade para aposentar";
            }else
            {
                return $"O jogador já tem idade para se aposentar";
            }
        }
    }
}
