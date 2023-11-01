using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class ExibeInicio
{
    public void ImprimeInicio()
    {
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
        Console.WriteLine("xxxxxxxxBem vindo ao Validador de notas !!xxxxxxxxxxxx");
        Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");
    }

    public void Imprime(List<Aluno> teste)
    {
        foreach (var aluno in teste)
        {
            Console.WriteLine($"Os nomes dos Alunos são {aluno.AlunoNome}");

            foreach (var nota in aluno.notas)
            {
                Console.WriteLine($"Matemática : {nota.NotaMat} | Português : {nota.NotaPor} | Fisíca {nota.NotaFis} | História {nota.NotaHis}");
            }            
        }        
    }
}