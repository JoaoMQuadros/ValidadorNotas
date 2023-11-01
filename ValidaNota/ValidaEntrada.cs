using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class ValidadorCaracter
{
    public int ValidaNotas()
    {
        int notaAlunoValida;
        string notaAluno;
        bool validEntry = false;
        {
            do
            {
                notaAluno = Console.ReadLine();
                int.TryParse(notaAluno, out notaAlunoValida);
                if (notaAluno != null)
                {
                    if (Convert.ToDecimal(notaAluno) >= 0 && Convert.ToDecimal(notaAluno) <= 10)
                    {
                        validEntry = true;

                    }
                    else
                    {
                        Console.WriteLine("Você não digitou a nota correga, faça novamente.");
                    }
                }
            } while (validEntry == false);
            return notaAlunoValida;
        }
    }

    //Metodo de não deixar carecter entrar 

    //public void BloqCarecter()
    //{
    //    double number;
    //    Console.Write("Enter the cost of the item: ");
    //    while (!double.TryParse(Console.ReadLine(), out number))
    //    {
    //        Console.Write("This is not valid input. Please enter an integer value: ");
    //    }

    //    Console.Write("The item cost is: {0}", number);
    //}
};

