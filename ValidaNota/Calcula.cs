using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class CalculaMedia
{
    public void MediaNotas(List<Aluno> lstAlunos)
    {
        List<Media> media = new List<Media>();
        Media acessaMedia = new Media();
        //Recebe o nome do Aluno;
        string nomeAluno = "";
        //Recebe as notas da Listas;
        double notaMat = 0;
        double notaPor = 0;
        double notaHis = 0;
        double notaFis = 0;
        //Soma das notas divida pela quantidade de vezes, para se ter média;
        double mediaMat = 0;
        double mediaPor = 0;
        double mediaHis = 0;
        double mediaFis = 0;
        //Adicionando as médias a lista
     
        // Loops para extrair o nome do Aluno;
        foreach (var alunos in lstAlunos)
        {
            nomeAluno += alunos.AlunoNome;
            //Loops para extrair as notas to Aluno;
            foreach (var notMateria in alunos.notas)
            {
                notaMat += notMateria.NotaMat;
                notaPor += notMateria.NotaPor;
                notaHis += notMateria.NotaHis;
                notaFis += notMateria.NotaFis;
            }
            //Realizar o calculo da média;
            acessaMedia.mediaMat = notaMat / alunos.notas.Count;
            acessaMedia.mediaPor = notaPor / alunos.notas.Count;
            acessaMedia.mediaHis = notaHis / alunos.notas.Count;
            acessaMedia.mediaFis = notaFis / alunos.notas.Count;                      
        }
        media.Add(acessaMedia);
    }
}