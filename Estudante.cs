using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public class Estudante : Pessoa, IAvaliavel
    {
        public int Matricula { get; set; }
        public Dictionary<Avaliacao, double> Notas { get; set; } = new Dictionary<Avaliacao, double>();

        public Estudante(string nome, string bi, int matricula) : base(nome, bi)
        {
            Matricula = matricula;
        }

        public double CalcularNotaFinal()
        {
            return Notas.Sum(n => n.Key.CalcularContribuicao(n.Value));
        }
    }
}