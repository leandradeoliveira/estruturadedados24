using System.Collections;
//utilizando uma lista simples
ArrayList arrayList = new ArrayList();
arrayList.Add(5);
arrayList.Add("Leandra");
// e posivel addicionar um conjunto de valore de uma so ves 

arrayList.AddRange(new int[] { 10, 15, 20, 25 });

// o metodo add insere o valor ao final do vetor 

arrayList.Insert(0,15);


// ja o metodo insert me permite incluir o valor desejado  em uma posicao especifica no primeiro parametro;

// lendo valores da lista objt primairo igaula arrlista [o]1;

object primeiro = arrayList[0]!;

int quarto = ( int )arrayList[3]!;

//percorendo 

foreach (object obj in arrayList)
{

Console.WriteLine( $" | {obj}");

}

// obetendo o tamanho total da lista int 

int tamanho = int arrlista.Count;

// ter a capacidade 

int capacidade = arrList.Capacity;

// percorendo no modo laco

for (int i = 0; i < arrlist; i++)
{
Console.write(  $" | {arrList[i]}");
}

// recursos importates da lista 
// verificar se um valor e contidfo bna lista 
bool contemNome =  arrayList.containes ("Leandra");

if (!contemNome)

Console.WriteLine(" Nome leandra  não encontrado");

// para saber o idice que contem o valor buscado 
// neste caso se o valor existir na lista ele retorna o indice do numero inteiro caso o valor nao existir na lista ele retorna 

int  indice = arrayList.IndexOf("Leandra");


if( indice >= 0)

Console.WriteLine( $"leandra esta em [{indeceValor}] ");

else
Console.WriteLine("E , realmente nao tem ,")
// e possivel remover item 

arrList.romov("leandra");

arrayList.removeAt(4); // remove indice 

arrayList.removeRange(0,2);


