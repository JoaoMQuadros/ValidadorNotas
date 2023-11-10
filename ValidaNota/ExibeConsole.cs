using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class ExibeInicio
{
    //Existe entrada para o Usuario
    public void ImprimeInicio()
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("xxxxxxxxBem vindo ao Validador de notas !!xxxxxxxxxxxx");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
    }
    //Existe as notas em cada Materia e cada Semestre,trimestre...
    public void ExibeBoletim(List<Aluno> lstNomeNotaMedia)
    {
        foreach (var aluno in lstNomeNotaMedia)
        {
            Console.WriteLine($"Alun(a):{aluno.AlunoNome}, segue abaixo registro de notas:");
            Console.WriteLine();
            foreach (var nota in aluno.notas)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Matemática : {nota.NotaMat} | Português : {nota.NotaPor} | Fisíca : {nota.NotaFis} | História : {nota.NotaHis}");
            }
            foreach (var media in aluno.media)
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                Console.WriteLine($"Média em Matemática : {media.MediaMat} |Média em  Português : {media.MediaPor} |Média em  Fisíca : {media.MediaFis} |Média em  História : {media.MediaHis}");
            }
        }
    }
    //Realiza a verifcação de aprovação dos Alunos;
    public void ValidaAprovacao(List<Aluno> lstAlunoNotaMedia)
    {
        foreach (var aluno in lstAlunoNotaMedia)
        {
            double mediaValidMat = 0;
            double mediaValidPor = 0;
            double mediaValidHis = 0;
            double mediaValidFis = 0;
            foreach (var media in aluno.media)
            {
                mediaValidMat += media.MediaMat;
                mediaValidPor += media.MediaPor;
                mediaValidHis += media.MediaHis;
                mediaValidFis += media.MediaFis;
            }
            if (mediaValidMat >= 7 && mediaValidPor >= 7 && mediaValidHis >= 7 && mediaValidFis >= 7)
            {
                Console.WriteLine($"O Alun(a) {aluno.AlunoNome} foi Aprovado !");
            }
            else if (mediaValidMat >= 5.5 && mediaValidPor >= 5.5 && mediaValidHis >= 5.5 && mediaValidFis >= 5.5)
            {
                Console.WriteLine($"O Alun(a) {aluno.AlunoNome} está em Recuperação !");
            }
            else
            {
                Console.WriteLine($"O Alun(a) {aluno.AlunoNome} está em Reprovado !");
            }
        }
    }
}