using CIS129FinalProject;
using System.ComponentModel;
using System.Data.Common;


//creating Dungeon & setting the starting point and exit point

int[,] dungeon = new int[5, 5] { {1,2,3,4,5}, 
                                 {6, 7, 8, 9, 10}, 
                                 {11, 12, 13, 14, 15}, 
                                 {16, 17, 18, 19, 20},
                                 {21,22,23,24,25}};
Random rnd = new Random();
int start = rnd.Next(1, dungeon.Length);
int end = rnd.Next(1, dungeon.Length);


// creating a characters 

Wizart player = new Wizart(100, 200);
Goblin goblin = new Goblin(3);
Banshee banshee = new Banshee(8);
Orc orc = new Orc(5);


//creating movement in the array
int move;







bool playGame;

// start is wizart location 
do
{     
           if (start != end)
            {

                player.Travel();
                move = Convert.ToInt16(Console.ReadLine());
                Move(move);
                Console.WriteLine($"The wizart is currently at {start}");
                Console.WriteLine(end);
               

            }
            else if(start == end)
            {
                Console.WriteLine("Would you like to play again");
                int yes = Convert.ToInt32(Console.ReadLine());
                if(yes == 1)
                {
                    playGame= true;
                }
                else
                    playGame = false;   
            }
          

}while (playGame = true);

//creating movement in the array
void Move(int move)
{
    switch (move)
    {
        case 1:
            if (start >= 1 && start <= 5)
            {
                Console.WriteLine("Cant move north any further");
            }
            else if (start >= 6 && start <= 25)
            {
                start = start - 5;
            }
            break;

        case 2:
            if (start >= 21 && start <= 25)
            {
                Console.WriteLine("You cant go south any further");
            }
            else if(start >= 1 && start <= 20)
            {
                start= start + 5;
            }
            break;


        case 3:
            if (start == 1)
            {
                Console.WriteLine("You cant left any further");
            }
            else if (start == 6)
            {
                Console.WriteLine("You cant left any further");
            }
            else if (start == 11)
            {
                Console.WriteLine("You cant left any further");
            }
            else if (start == 16)
            {
                Console.WriteLine("You cant left any further");
            }
            else if (start == 21)
            {
                Console.WriteLine("You cant left any further");
            }
            else
                start = start - 1;
            break;
            //{1,2,3,4,5}, 
            //{ 6, 7, 8, 9, 10}, 
            //{ 11, 12, 13, 14, 15}, 
            //{ 16, 17, 18, 19, 20},
            //{ 21,22,23,24,25}

        
        case 4:
            if (start == 5)
            {
                Console.WriteLine("You cant go west any further");
            }
            else if (start == 10)
            {
                Console.WriteLine("You cant go west any further");
            }
            else if (start == 15)
            {
                Console.WriteLine("You cant go west any further");
            }
            else if (start == 20)
            {
                Console.WriteLine("You cant go west any further");
            }
            else if (start == 25)
            {
                Console.WriteLine("You cant go west any further");
            }
            else
                start = start + 1;
            break;


    }
}