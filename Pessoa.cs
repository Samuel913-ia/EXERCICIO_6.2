using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string BI { get; set; }
        protected Pessoa(string nome, string bi)
        {
            Nome = nome;
            BI = bi;
        }
    }
}