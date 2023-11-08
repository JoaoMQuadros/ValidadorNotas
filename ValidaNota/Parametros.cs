using System.Collections.Generic;

public class Aluno
{
    public string AlunoNome { get; set;}
    public List<Notas> notas = new List<Notas>();
    public List<Media> media = new List<Media>();

}

public class Notas
{
    public double NotaMat { get; set; }
    public double NotaPor { get; set; }
    public double NotaHis { get; set; }
    public double NotaFis { get; set; }
}

public class Media
{
    public double mediaMat { get; set; }
    public double mediaPor { get; set; }
    public double mediaHis { get; set; }
    public double mediaFis { get; set; }
}