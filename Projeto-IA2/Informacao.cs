public class Informacao
{
    public Informacao(string nome, int[] valor, int resultado)
    {
        Nome = nome;
        Valor = valor;
        Resultado = resultado;
    }
    public string Nome {get;}
    public int[] Valor {get;}
    public int Resultado {get;}
    public bool Aprovado {get;set;}

    public override string ToString() => $"Nome: {Nome} , Aprovado: {Aprovado}  , Resultado Esperado: {Resultado}";
}