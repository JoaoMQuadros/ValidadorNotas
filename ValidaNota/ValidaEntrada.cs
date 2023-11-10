using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


public class Validacao
{
    //Metodo Valida entrada (Somente número entre 1 a 10 e Caracteres)

    public double ValidaNotas()
    {
        double notaValidada;
        bool validador = false;
        double recebeNotaValida;
        do 
        {
            string recebeaNota = Console.ReadLine();
            if(double.TryParse(recebeaNota, out notaValidada) && notaValidada >= 0 && notaValidada <= 10)
            {
                validador = true;
                Console.WriteLine("Nota registrada !");
            }
            else
            {
                Console.WriteLine("Por favor, apenas valores entre 0 a 10 !");
            }           
        }
        while (validador == false) ;
        return notaValidada;       
    }   

    //Metodo de não deixar carecter entrar (Bloqueia Numero)

    public double BloqCarecter()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Por favor, digíte apenas números !!");
        }
        return number;

    }
   
};

