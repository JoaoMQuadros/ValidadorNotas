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
    public double MediaMat { get; set; }
    public double MediaPor { get; set; }
    public double MediaHis { get; set; }
    public double MediaFis { get; set; }
}


public class ColetaDivMediaQtAluno
{
    public int qntNotas { get; set; }
    public int qntAlunos { get; set; }
}