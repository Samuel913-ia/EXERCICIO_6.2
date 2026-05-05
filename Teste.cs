using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public class Teste : Avaliacao
    {
        public Teste(double peso) : base("Teste", peso) { }
        public override double CalcularContribuicao(double n) => n * Peso;
    }
}