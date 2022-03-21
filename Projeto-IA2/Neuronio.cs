namespace Projeto_IA2
{
    public class Neuronio
    {
        public int W {get; set;}
        public int X {get; set;}
        public int Resultado => X * W;

        public virtual void RecebaInformacao(int valorRecebido){
            X = valorRecebido;
        }

        public void AjustePeso(int valorEsperado, int valorResultante){
            int valorErro = valorEsperado - valorResultante;

            W = W + (valorErro * 1 * X);
        }
    }
}