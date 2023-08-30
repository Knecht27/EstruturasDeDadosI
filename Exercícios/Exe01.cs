// 1 - Crie o projeto Console Exe01
// 2 - Crie um vetor de int com 10 posição 
// 3 - Carregue valores no vetor e exiba desordenado
// 4 - Escreva um algoritmo em C# para ordenar os valores
// 5 - Imprima os valores ordenados



int [] numbers = new int [10] {71, 85, 21, 8, 18, 81, 91, 42, 38, 87}; //Declara o tamanho e o conteudo do vetor
foreach (int i in numbers) //Percore e lê dentro do vetor
Console.WriteLine(i); // imprime o vetor

Console.WriteLine(" "); // Imprime um espaço pra entender está merda
Console.WriteLine("Ordenado");
Console.WriteLine(" ");

Array.Sort(numbers); // organiza os números dentro do vetor
foreach (int i in numbers)
Console.WriteLine(i);

