using System.Collections.Generic;
using System;
using System.Globalization;

public class RecolheEntrada
{
   public void RecolheNome()
    {
        Aluno aluno = new Aluno();
        Console.WriteLine("Qual o Nome do Aluno?");
        aluno.AlunoNome = Console.ReadLine();
        
    }
    
   public void RecolheNota() 
    {
        Aluno aluno = new Aluno();
        Notas notas = new Notas();
        List<Notas> lstNotas = new List<Notas>();

        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Matemática ?");
        notas.NotaMat = Convert.ToInt32( Console.ReadLine() );
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Português ?");
        notas.NotaPor = Convert.ToInt32( Console.ReadLine() );  
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em Fisíca ?");
        notas.NotaFis = Convert.ToInt32( Console.ReadLine() );  
        Console.WriteLine($"Qual a nota do {aluno.AlunoNome} em História ?");
        notas.NotaHis = Convert.ToInt32( Console.ReadLine() );
        lstNotas.Add( notas );        

    }

    public void Imprime(List<Notas> notas)
    {
        Aluno aluno = new Aluno();        
        for(int i = 0; i < 0; i++)
        {
            Console.WriteLine($"As notas para o {aluno.AlunoNome} foram as seguintes n\"Matemática:{notas[i].NotaMat} n\"Português: {notas[i].NotaPor}n\"" +
                $"Fisíca: {notas[i].NotaFis}n\"Histórica: {notas[i].NotaHis}");
        }     
    }
}
