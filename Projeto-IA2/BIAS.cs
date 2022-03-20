using Projeto_IA2;

public class BIAS : Neuronio
{
    public BIAS()
    {
        X = 1;
        W = 0;
    }
    public override string Name {get => "BIAS";}
    public override void RecebaInformacao(int valorRecebido = 0) => throw new Exception("Operação inválida");
}