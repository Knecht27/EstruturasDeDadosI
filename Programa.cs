int [] numbers;
numbers = new int[5];

numbers [0] = 9;
numbers[1] = - 11;
numbers [2] = 5
numbers [3] = 7
numbers [4] = - 4
//numbers [5] = 8; ERRO! FORA DOS LIMITES

int [] numbers2 = new int[] {9,-11,5,7,-4};

int [] numbers3 = {9,-11,5,7,-4};

// Laço de Repetição
for(int i = 0; i < numbers.Length; i++; ) 
{
    Console.WriteLine( numbers[i] );
}
