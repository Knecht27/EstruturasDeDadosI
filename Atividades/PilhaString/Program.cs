using System;

Stack<string>  PilhaString = new Stack<string>(); //Criar uma pilha de strings

PilhaString.Push("Bom Dia!");
PilhaString.Push("Guten Morgen!");
PilhaString.Push("Good Morning!");
PilhaString.Push("¡Buenos días!");

string topo = PilhaString.Peek ();   // Pegar o elemento no topo da pilha
Console.WriteLine("Elemento no topo da pilha é: "+ topo );

string desempilhar = PilhaString.Pop ();  //Pega o primeiro dado da pilha e retira ele
Console.WriteLine("Elemento desempilhado: " + desempilhar );

int tamanho = PilhaString.Count; //Apresenta o tamanho da pilha
Console.WriteLine("Tamanho desta pilha é: " + tamanho);

Console.WriteLine("Elementos da pilha:"); // Exibe a pilha inteira
foreach (string elemento in PilhaString)
{
    Console.WriteLine(elemento);
}