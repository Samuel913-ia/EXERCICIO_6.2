using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public class Projecto : Avaliacao
    {
        public Projecto(double peso) : base("Projecto", peso) { }
        public override double CalcularContribuicao(double n) => n * Peso;
    }
}