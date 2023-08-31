int[,] biNumbers = new int[5,2]; //Matriz bidimensional (bibagual)

int [,,] Trinumbers = new int [5,4,3]; //Matriz tridimensional(tribagual)

int [,] loadedbinumbers = new int [,] 
{
    {   9,  5,  8},
    {  10, -11, 4},
    { 101, 45, -9}
};

for(int i = 0; i < loadedbinumbers.GetLength(0); i++)
{
    for(int j = 0; j < loadedbinumbers.GetLength(1); j++)
    {
        Console.Write(
            $"[{ loadedbinumbers[i,j]}]"
            );
    }
    Console.WriteLine("");
}