using System.Collections.Generic;
using System.Text;

namespace ClubeDaLeitura_2_0.ConsoleApp
{
    public class ResultadoValidacao
    {

        private readonly List<string> erros;
        public ResultadoValidacao(List<string> erros)
        {
            this.erros = erros;
        }

       

        public StatusValidacao Status
        {
            get
            {
                return this.erros.Count == 0 ? StatusValidacao.Ok : StatusValidacao.Erro;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (string erro in this.erros)
            {
                if (!string.IsNullOrEmpty(erro))
                    sb.AppendLine(erro);
            }

            return sb.ToString();
        }
    }
}