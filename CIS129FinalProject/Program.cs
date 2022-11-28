using CIS129FinalProject;


//creating Dungeon & setting the starting point and exit point
int[,] dungeon = new int[5, 5] { {1,2,3,4,5},
                                 {6,7,8,9,10},
                                 {11,12,13,14,15},
                                 {16,17,18,19,20},
                                 {21,22,23,24,25}};

Random random = new Random();
int startingPoint = random.Next(1, 26);
int exitPoint = random.Next(1, 26);


//creating a wizart 

Wizart player = new Wizart(1 , 15);
player.UseHeal();
player.UseHeal();
player.UseHeal();
player.IsAlive();
int userInput;

bool playGame;
