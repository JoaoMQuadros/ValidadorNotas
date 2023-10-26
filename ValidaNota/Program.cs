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
            List<Aluno> alunos = new List<Aluno>();
            ExibeInicio exibeConsole = new ExibeInicio();          
            RecolheEntrada recolhe = new RecolheEntrada();
            

//----------Metódos :  ---------------------------------------------------------------------------------------------------------------------------------    
            exibeConsole.ImprimeInicio();
            recolhe.SolicitaEntrada(aluno, recolhe);
            exibeConsole.Imprime(aluno);
            alunos.Add(aluno);           
 //----------FIM : ---------------------------------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
        }   
             
    }
}
