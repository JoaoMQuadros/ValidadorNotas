using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ValidaNota
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ExibeInicio exibeInicio = new ExibeInicio();
            List<Notas> lstNotas = new List<Notas>();
            RecolheEntrada recolhe = new RecolheEntrada();




            exibeInicio.ImprimeInicio();

            recolhe.RecolheNome();
            recolhe.RecolheNota();
            recolhe.Imprime();

                  
                                            



            Console.ReadLine();
        }


    }
}
