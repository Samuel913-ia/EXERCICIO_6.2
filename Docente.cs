using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public abstract class Docente : Pessoa
    {
        public string Departamento { get; set; }
        protected Docente(string nome, string bi, string depto) : base(nome, bi)
        {
            Departamento = depto;
        }
    }
}