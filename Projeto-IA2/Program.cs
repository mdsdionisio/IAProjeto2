using Projeto_IA2;

var listaDados = Limitado.ObtenhaPadrao1();
var neuronios = listaDados.First().Valor.Select(elemento => new Neuronio()).ToArray();

var bias = new BIAS();
int contador = 1;

while(TemReprovado(listaDados)){
    Console.WriteLine($"Interação {contador} ===================================");
    PrincipalTreino();
    Console.WriteLine("===============================================");
    contador++;
}

bool TemReprovado(Informacao[] listaDados) => listaDados.Any(l => !l.Aprovado);

void PrincipalTreino(){
    foreach(var dado in listaDados!){
        int resultado = ObtenhaResultado(dado.Valor);

        if(resultado != dado.ResultadoEsperado){
            Console.WriteLine($"Erro: {dado.ToString()} Resultado Obtido: {resultado}");

            AjusteNeuronios(dado.ResultadoEsperado, resultado);
            ReproveTodasInformacoes();
                
            continue;            
        }

        dado.Aprovado = true;
        Console.WriteLine($"Aprovado: {dado.ToString()} Resultado Obtido: {resultado}");
    }
    MostreNeuroniosResultantes();
}

void MostreNeuroniosResultantes(){
    int x = 0;
    foreach (var neuronio in neuronios){
        Console.WriteLine($"N{x} = W{x} : {neuronio.W}");
        x++;
    }
    Console.WriteLine($"bias = Wbias : {bias.W}");
}

void PrincipalTreinado(){
    neuronios![0].W = -1;
    neuronios[1].W = 1;
    neuronios[2].W = -1;
    neuronios[3].W = 1;
    bias!.W = 0;

    foreach(var dado in listaDados!){
        string resultado = ObtenhaResultado(dado.Valor) == 1 ? "Refriado": "Gripe";
        dado.Aprovado = true;
        Console.WriteLine($"Dado: {dado.Nome} Resultado Obtido: {resultado}");
    }
}

int ObtenhaResultado(int[] valor)
{
    int resultado = 0;

    for(int i = 0; i < valor.Length; i++){
        neuronios![i].RecebaInformacao(valor[i]);
        resultado += neuronios[i].Resultado;
    }

    resultado = resultado + bias!.Resultado;

    return resultado > 0 ? 1 : 0;
}

void AjusteNeuronios(int resutaldoEsperado, int resultado)
{
    foreach(var neuronio in neuronios!){
        neuronio.AjustePeso(resutaldoEsperado, resultado);
    }

    bias!.AjustePeso(resutaldoEsperado, resultado);
}

void ReproveTodasInformacoes()
{
    foreach(var dadoPossiveis in listaDados){
        dadoPossiveis.Aprovado = false;
    }
}

