namespace Facade
{
    public class ScoreClienteFacade
    {
        DetranAPI detran = new();
        SerasaAPI serasa = new();
        ReceitaFederalAPI receita = new();

        public double Score(string CPF, string CNH)
        {
            var cnhValida = detran.CNHValida(CNH);
            var scoreSerasa = serasa.Score(CPF);
            var cpfAtivo = receita.CPFAtivo(CPF);

            var scoreSerasa20p100 = scoreSerasa * 0.2;
            var scoreSerasa30p100 = scoreSerasa * 0.3;
            var Score = scoreSerasa * 1.0;

            if (!cnhValida)
                Score = (Score - scoreSerasa20p100);

            if (!cpfAtivo)
                Score = (Score - scoreSerasa30p100);

            return Score;
        }
    }
}