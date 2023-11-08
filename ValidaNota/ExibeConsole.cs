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

    public void ExibeBoletim(List<Aluno> nameAndAvarange)
    {
        foreach (var aluno in nameAndAvarange)
        {
            Console.WriteLine($"Alun(a):{aluno.AlunoNome}, segue abaixo registro de notas:");
            Console.WriteLine();
            foreach (var nota in aluno.notas)
            {
                Console.WriteLine($"Matemática : {nota.NotaMat} | Português : {nota.NotaPor} | Fisíca : {nota.NotaFis} | História : {nota.NotaHis}");
                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                
            }
        }
    }
}