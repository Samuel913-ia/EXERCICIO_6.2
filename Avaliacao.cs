using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public abstract class Avaliacao
    {
        public string Nome { get; set; }
        public double Peso { get; set; }
        protected Avaliacao(string nome, double peso)
        {
            Nome = nome;
            Peso = peso;
        }
        public abstract double CalcularContribuicao(double notaBruta);
    }
}