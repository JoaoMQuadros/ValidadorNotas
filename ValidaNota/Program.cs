using System;using System.Collections.Generic;
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
//----------Importando Classes :  ----------------------------------------------------------------------------------------------------------------------  
                
            Aluno aluno = new Aluno();        
            List<Aluno> lstAlunos = new List<Aluno>();
            ExibeInicio exibeConsole = new ExibeInicio();          
            RecolheEntrada recolhe = new RecolheEntrada();
            

//----------Metódos :  ---------------------------------------------------------------------------------------------------------------------------------    
            exibeConsole.ImprimeInicio();
            recolhe.teste(recolhe, lstAlunos);
            exibeConsole.Imprime(lstAlunos);

            lstAlunos.Add(aluno);           
 //----------FIM : ---------------------------------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
        }   
             
    }
}
