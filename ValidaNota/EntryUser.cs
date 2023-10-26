using System.Collections.Generic;

public class Aluno
{
    public string AlunoNome { get; set;}
    public List<Notas> notas = new List<Notas>();

}
public class Notas
{
    public int NotaMat { get; set;}
    public int NotaPor { get; set; }
    public int NotaHis { get; set; }
    public int NotaFis { get; set; }

}