using System.Collections.Generic;
using System;
using System.Globalization;

public class RecolheEntrada
{
    Validacao validaNota = new Validacao();



    //Recolhe Nome  ==========================================================================================================================================
    public void RecolheNome(Aluno aluno, List<Aluno> nomes)
    {
        Console.WriteLine("Qual o nome do Aluno(a) a ser inscrito ?");
        aluno.AlunoNome = Convert.ToString(validaNota.BloqEntryChar());

    }

    //Recolhe Notas  ===========================================================================================================================================
    public void RecolheNota(Aluno aluno)
    {
        Notas notas = new Notas();
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Matemática ?");
        notas.NotaMat = validaNota.ValidNote();        
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Português ?");
        notas.NotaPor = validaNota.ValidNote();
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Fisíca ?");
        notas.NotaFis = validaNota.ValidNote();
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em História ?");
        notas.NotaHis = validaNota.ValidNote();
        aluno.notas.Add(notas);        
        Console.Clear();       
    }
    //Para Saber a média dos Alunos ===========================================================================================================================
    public void teste(RecolheEntrada recolhe, List<Aluno> lstAlunos)
    {
        ColetaDivMediaQtAluno recolheDivisor = new ColetaDivMediaQtAluno();
        Console.WriteLine("Quantos Alunos(a) serão inscritos no Validador ?");
        recolheDivisor.qntAlunos = Convert.ToInt32(validaNota.BloqEntryChar());
        Console.WriteLine("Quantas vezes as notas serão dividas para se ter a média ?");
        recolheDivisor.qntNotas = Convert.ToInt32(validaNota.BloqEntryChar());
        for (int i = 0; i < recolheDivisor.qntAlunos; i++)
        {
            Aluno adiciona = new Aluno();
            recolhe.RecolheNome(adiciona, lstAlunos);
            lstAlunos.Add(adiciona);
            {
                for (int j = 0; j < recolheDivisor.qntNotas; j++)
                {
                    recolhe.RecolheNota(adiciona);
                }
            }
        }
    }
}