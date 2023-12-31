﻿using System;using System.Collections.Generic;
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
            //----------Listas :  --------------------------------------------------------------------------------------------------------------------- 
            List<Aluno> lstAlunos = new List<Aluno>();
            //----------Importando Classes :  ---------------------------------------------------------------------------------------------------------
            ExibeInicio exibeConsole = new ExibeInicio();
            Calculo calculo = new Calculo();
            RecolheEntrada recolhe = new RecolheEntrada();
            
            //----------Metódos :  --------------------------------------------------------------------------------------------------------------------
            exibeConsole.ImprimeInicio();
            recolhe.teste(recolhe, lstAlunos);
            calculo.ExibeMedia(lstAlunos);
            exibeConsole.ExibeBoletim(lstAlunos);
            exibeConsole.ValidaAprovacao(lstAlunos);

            //----------FIM : -------------------------------------------------------------------------------------------------------------------------
            Console.ReadLine();
        }   
             
    }
}
