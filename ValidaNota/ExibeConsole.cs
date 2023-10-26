using System;

public class ExibeInicio
{
    public void ImprimeInicio()
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("xxxxxxxxBem vindo ao Validador de notas !!xxxxxxxxxxxx");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
    }

    public void Imprime(Aluno aluno)
    {
        foreach (var alunos in aluno.notas)
        {
            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
            Console.WriteLine($"As notas do {aluno.AlunoNome} foram as seguintes:");
            Console.WriteLine($"Matemática: {alunos.NotaMat} ");
            Console.WriteLine($"Português: {alunos.NotaPor}");
            Console.WriteLine($"Histórica: {alunos.NotaHis}");
            Console.WriteLine($"Fisíca: {alunos.NotaFis}");
        };
    }

}