using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sistema_Academico_Exercicio62
{
    public class UnidadeCurricular
    {
        public string NomeUC { get; set; }
        private List<Estudante> estudantes = new List<Estudante>();
        private List<Avaliacao> avaliacoes = new List<Avaliacao>();

        public UnidadeCurricular(string nome)
        {
            NomeUC = nome;

            avaliacoes.Add(new Teste(0.3));
            avaliacoes.Add(new Projecto(0.3));
            avaliacoes.Add(new ExameFinal(0.4));
        }

        public void IncreverEstudante(Estudante e)
        {
            estudantes.Add(e);
        }

        public void LancarNota(Estudante est, int indexAvaliacao, double nota)
        {
            est.Notas[avaliacoes[indexAvaliacao]] = nota;
        }

        public void EmitirPauta()
        {
            Console.WriteLine($"\nPAUTA FINAL - {NomeUC.ToUpper()}");
            Console.WriteLine("-------------------------------------------------");

            var pauta = estudantes.OrderByDescending(e => e.CalcularNotaFinal()).ToList();

            foreach (var e in pauta)
            {
                Console.WriteLine($"ID: {e.Matricula} | Nome: {e.Nome} | Média: {e.CalcularNotaFinal():F2}");
            }
        }
    }
}