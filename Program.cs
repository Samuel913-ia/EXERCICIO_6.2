using Exercicio6._2;

namespace Sistema_Academico_Exercicio62
{
    public class Program
    {
        static void Main()
        {
            UnidadeCurricular uc = new UnidadeCurricular("Programação Orientada a Objectos II");
            Docente prof = new Titular("Joaquim Ventura", "00123UNK", "Engenharia Informática");

            Estudante e1 = new Estudante("José Silva", "020693761UE051", 202601);
            Estudante e2 = new Estudante("Ariel Manuel", "07993761UE0049", 202602);
            Estudante e3 = new Estudante("Pedro Bengui", "77993761UE0047", 202603);

            uc.IncreverEstudante(e1);
            uc.IncreverEstudante(e2);
            uc.IncreverEstudante(e3);

            uc.LancarNota(e1, 0, 14); uc.LancarNota(e1, 1, 16); uc.LancarNota(e1, 2, 12);
            uc.LancarNota(e2, 0, 18); uc.LancarNota(e2, 1, 19); uc.LancarNota(e2, 2, 17);
            uc.LancarNota(e3, 0, 10); uc.LancarNota(e3, 1, 12); uc.LancarNota(e3, 2, 11);

            uc.EmitirPauta();
            Console.ReadLine();
        }
    }
}
