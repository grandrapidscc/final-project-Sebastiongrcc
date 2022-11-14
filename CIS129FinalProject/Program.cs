
// creating dungeon 
int[,] dungeon = new int[5, 5] { {1,2,3,4,5}, 
                                 {6,7,8,9,10}, 
                                 {11,12,13,14,15}, 
                                 {16,17,18,19,20}, 
                                 {21,22,23,24,25}};


shuffleArray(dungeon);
int startingPoint;

// i think this has to be in the actual game loop for a new random spot?
for(int i = 0; i<1; i++)
{
    for(int j = 0; j < 1; j++)
    {
        startingPoint = dungeon[i,j];
        Console.WriteLine(startingPoint);
        
    }  
}





void shuffleArray(int[,] arr)
{
    int n = arr.GetLength(0);
    int m = arr.GetLength(1);

    Random rand = new Random();
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            swap(arr, i + rand.Next(n - i), j + rand.Next(m - j), i, j);
        }
    }

}
 void swap(int[,] arr, int changed, int changedB, int a, int b)
{

    int temp = arr[a, b];
    arr[a, b] = arr[changed, changedB];
    arr[changed, changedB] = temp;
   
}