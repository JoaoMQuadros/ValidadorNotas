using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

public class Calculo
{
    public void ExibeMedia(List<Aluno> lstAlunoNotasMedia)
    {   //Laço para acessar cada item da lista;
        foreach (var expNotas in lstAlunoNotasMedia)
        {
            Media addMedia = new Media();
            //Parametro para amarzenar os valores retirados da Lista;
            double somaNotasMat = 0;
            double somaNotasPor = 0;
            double somaNotasHis = 0;
            double somaNotasFis = 0;
            //Laço para acessar cada item da lista dentro de outra Lista;
            foreach (var notas in expNotas.notas)
            {   //Desmebra a Lista;
                somaNotasMat += notas.NotaMat;
                somaNotasPor += notas.NotaMat;
                somaNotasHis += notas.NotaMat;
                somaNotasFis += notas.NotaMat;                
            }
            //Realiza a média das notas que estão adicionadas na lista;
            addMedia.MediaMat = somaNotasMat / expNotas.notas.Count;
            addMedia.MediaPor = somaNotasPor / expNotas.notas.Count;
            addMedia.MediaHis = somaNotasHis / expNotas.notas.Count;
            addMedia.MediaFis = somaNotasFis / expNotas.notas.Count;
            //Adiciona a media da lista de notas na lista de média;
            expNotas.media.Add(addMedia);
        }
    }
    
}