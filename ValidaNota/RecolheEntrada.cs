﻿using System.Collections.Generic;
using System;
using System.Globalization;

public class RecolheEntrada
{
    //Recolhe Nome  ==========================================================================================================================================
    public void RecolheNome(Aluno aluno, List<Aluno> nomes)
    {
        Console.WriteLine("Qual o nome do Aluno(a) a ser inscrito ?");
        aluno.AlunoNome = Console.ReadLine();   

    }

    //Recolhe Notas  ===========================================================================================================================================
    public void RecolheNota(Aluno aluno)
    {
        Validacao validaNota = new Validacao();
        Notas notas = new Notas();


        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Matemática ?");
        notas.NotaMat = validaNota.ValidaNotas();        
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Português ?");
        notas.NotaPor = validaNota.ValidaNotas();
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Fisíca ?");
        notas.NotaFis = validaNota.ValidaNotas();
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em História ?");
        notas.NotaHis = validaNota.ValidaNotas();
        aluno.notas.Add(notas);        
        Console.Clear();       
    }
    //Para Saber a média dos Alunos ===========================================================================================================================
    public void teste(RecolheEntrada recolhe, List<Aluno> lstAlunos)
    {
        ColetaDivMediaQtAluno recolheDivisor = new ColetaDivMediaQtAluno();
        Validacao validaEntrada = new Validacao();
        Console.WriteLine("Quantos Alunos(a) serão inscritos no Validador ?");
        recolheDivisor.qntAlunos = Convert.ToInt32(validaEntrada.BloqChar());
        Console.WriteLine("Quantas vezes as notas serão dividas para se ter a média ?");
        recolheDivisor.qntNotas = Convert.ToInt32(validaEntrada.BloqChar());
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