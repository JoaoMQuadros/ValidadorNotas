using System.Collections.Generic;

public class Aluno
{
    public string AlunoNome { get; set;}
    public List<Notas> notas = new List<Notas>();

}
public class Notas
{
    public double NotaMat { get; set;}
    public double NotaPor { get; set; }
    public double NotaHis { get; set; }
    public double NotaFis { get; set; }

}