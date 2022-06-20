using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDaLeitura_2_0.ConsoleApp
{
    internal class Caixa : EntidadeBase 
    {
        public string cor;
        public string etiqueta;
        public Revista[] revistas;

        public override string ToString()
        {
            return "Número: " + numero + Environment.NewLine +
            "Cor: " + cor + Environment.NewLine +
            "Etiqueta: " + etiqueta + Environment.NewLine;
        }

        public override ResultadoValidacao Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(cor))
                erros.Add("É necessário inserir uma cor para as caixas!");

            if (string.IsNullOrEmpty(etiqueta))
                erros.Add("Por favor insira uma etiqueta válida!");

            return new ResultadoValidacao(erros);
        }
    }
}
