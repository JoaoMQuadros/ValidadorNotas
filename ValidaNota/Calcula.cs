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
    {
        foreach (var expNotas in lstAlunoNotasMedia)
        {
            Media addMedia = new Media();
            double somaNotasMat = 0;
            double somaNotasPor = 0;
            double somaNotasHis = 0;
            double somaNotasFis = 0;
            foreach (var notas in expNotas.notas)
            {
                somaNotasMat += notas.NotaMat;
                somaNotasPor += notas.NotaMat;
                somaNotasHis += notas.NotaMat;
                somaNotasFis += notas.NotaMat;

                addMedia.MediaMat = somaNotasMat / lstAlunoNotasMedia.Count;
                addMedia.MediaPor = somaNotasPor / lstAlunoNotasMedia.Count;
                addMedia.MediaHis = somaNotasHis / lstAlunoNotasMedia.Count;
                addMedia.MediaFis = somaNotasFis / lstAlunoNotasMedia.Count;
            }
            expNotas.media.Add(addMedia);
        }

    }
}