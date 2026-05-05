using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public class ExameFinal : Avaliacao
    {
        public ExameFinal(double peso) : base("Exame Final", peso) { }
        public override double CalcularContribuicao(double n) => n * Peso;
    }
}