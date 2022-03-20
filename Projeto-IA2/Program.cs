using Projeto_IA2;

var listaDados = Limitado.ObtenhaPadrao1();
var neuronios = listaDados.First().Valor.Select(elemento => new Neuronio()).ToArray();

var bias = new BIAS();
int contador = 1;

while(TodosValidos(listaDados)){
    Console.WriteLine($"Interação {contador} ===================================");
    PrincipalTreino();
    Console.WriteLine("===============================================");
    contador++;
}

bool TodosValidos(Informacao[] listaDados) => listaDados.Any(l => !l.Aprovado);

void PrincipalTreino(){
    foreach(var dado in listaDados!){
        int resultado = ObtenhaResultado(dado);
        if(resultado != dado.Resultado){
            Console.WriteLine($"Erro: {dado.ToString()} Resultado Obtido: {resultado}");

            AjusteNeuronios(dado.Resultado, resultado);
            ReseteAprovados();
                
            continue;            
        }
        dado.Aprovado = true;
        Console.WriteLine($"Aprovado: {dado.ToString()} Resultado Obtido: {resultado}");
    }
    MostreResultado();
}

void MostreResultado(){
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
        string resultado = ObtenhaResultado(dado) ==1?"Refriado": "Gripe";
        dado.Aprovado = true;
        Console.WriteLine($"Dado: {dado.Nome} Resultado Obtido: {resultado}");
    }
}

int ObtenhaResultado(Informacao dado)
{
    int resultado = 0;

    for(int i = 0; i < dado.Valor.Length; i++){
        neuronios![i].RecebaInformacao(dado.Valor[i]);
        resultado += neuronios[i].Resultado;
    }

    resultado = resultado + bias!.Resultado;

    return resultado > 0 ? 1:0;
}

void AjusteNeuronios(int resutaldoEsperado, int resultado)
{
    foreach(var neuronio in neuronios!){
        neuronio.AjustePeso(resutaldoEsperado, resultado);
    }

    bias!.AjustePeso(resutaldoEsperado, resultado);
}

void ReseteAprovados()
{
    foreach(var dadoPossiveis in listaDados){
        dadoPossiveis.Aprovado = false;
    }
}

