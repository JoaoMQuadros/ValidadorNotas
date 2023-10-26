using System.Collections.Generic;
using System;
using System.Globalization;

public class RecolheEntrada
{
//Recolhe Nome  //-------------------------------------------------------------------------------------------
    public void RecolheNome(Aluno aluno)
    {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine("Qual o Nome do Aluno?");
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            aluno.AlunoNome = Console.ReadLine();
            Console.Clear();            
    }

//Recolhe Notas   //-------------------------------------------------------------------------------------------
    public void RecolheNota(Aluno aluno)
    {
        ValidadorCaracter validaNota = new ValidadorCaracter();

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
    //-------------------------------------------------------------------------------------------

    public void SolicitaEntrada(Aluno aluno, RecolheEntrada recolhe)
    {
        Console.WriteLine("Quantos Alunos serão incritos ?: ");
        int qntAluno = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Quantos vezes será divido a Média ?: ");        
        int qntMes = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        for (int i = 0; i < qntAluno; i++)
        {
            recolhe.RecolheNome(aluno);
            {
                for (int j = 0; j < qntMes; j++)
                {
                    recolhe.RecolheNota(aluno);
                }
            }
        }      
    }
}