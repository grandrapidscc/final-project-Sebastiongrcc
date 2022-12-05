using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Wizart
    {
        private int _wizartHp;
        private int _wizartMp;
        private int _fireballDamage;
        private int _fireballMagicCost;
        private int _healdamage;
        private int _healMagicCost;
        private string _enemyAttack;


        public Wizart(int wizartHp, int wizartMp)
        {
            _wizartHp = wizartHp;
            _wizartMp = wizartMp;
            

        }   
        
        // Battle options 
        public void UseFireball()
        {
            if(_wizartMp < 3)
            {
                Console.WriteLine("Not enough MP");
            }
            else
            {

                Console.WriteLine($"Wizart mp{_wizartMp} and did {_fireballDamage} damage");
                _wizartMp = _wizartMp - 3;
            }
        }
        public void UseHeal() 
        { 
            if(_wizartMp < 5) {

                Console.WriteLine("Not enough MP");
            }
            else
            {
                _wizartMp = _wizartMp - 5;
                _wizartHp = _wizartHp + 3;
                Console.WriteLine($"Wizart health is now at {_wizartHp} and MP is at {_wizartMp}");
               
            }
     
        }

        public void UseFlee()
        {
            Random random = new Random();
            int fleeChance = random.Next(1, 3);
            if (fleeChance % 2 == 0)
            {
                Console.WriteLine("Wizart fled");
            }
            else
            {
                Console.WriteLine("Failed to Escape!!");
            }

        }

        public bool IsAlive()
        {
            bool isAlive;
            if(_wizartHp <= 0) 
            {
                Console.WriteLine("Wizart has been defeated");
                isAlive = false; 
            }
            else
            {
                isAlive = true;
            }
            return isAlive;
        }
    

        // Potions 
        public void UseHpPotion()
        {
            _wizartHp+= 10;
            Console.WriteLine($"Wizart Consumed the Health potion and is now at {_wizartHp} health");
        }

        public void UseMpPotion()
        {
            _wizartMp += 20;
            Console.WriteLine($"Wizart Consumed the Mana potion and is now at {_wizartMp} mana");
        }

        // Battle system

        public void Battle(string name, int health)
        {
            Console.WriteLine($"You have encountered a {name}");
            Console.WriteLine($"It's current HP: {health}");
            Console.WriteLine("1: Attack");
            Console.WriteLine("2: Heal");
            Console.WriteLine("3: Flee");
            int input = Convert.ToInt16(Console.ReadLine());
            if(input == 1)
            {
                UseFireball();
            }
            if(input == 2)
            {
                UseHeal();
            }
            if(input == 3)
            {
                UseFlee();
                health = 0;
            }
        }

       public void TakeDamage(int enemyDamage, string enemyAttack)
        {
            _wizartHp -= enemyDamage;
            _enemyAttack = enemyAttack;
            Console.WriteLine($"Wizart took {enemyDamage} from {_enemyAttack} and has {_wizartHp} health remaning");
        }

        
        public void Travel()
        {
            Random random = new Random();

            int num = random.Next(1,7);

            
            if(num == 1)
            {
                Console.WriteLine("You are in a room dimly lit by torches. How do you proceed....");
                Console.WriteLine("1. To go North");
                Console.WriteLine("2. To go South");
                Console.WriteLine("3. To go East");
                Console.WriteLine("4. To go West");
            }
            if (num == 2)
            {
                Console.WriteLine("You see a pile of corpses, unsure of what killed. Dare to move?");
                Console.WriteLine("1. To go North");
                Console.WriteLine("2. To go South");
                Console.WriteLine("3. To go East");
                Console.WriteLine("4. To go West");
            }
            if (num == 3)
            {
                Console.WriteLine("You smell a stench....");
                Console.WriteLine("1. To go North");
                Console.WriteLine("2. To go South");
                Console.WriteLine("3. To go East");
                Console.WriteLine("4. To go West");
            }
            if (num == 4)
            {
                Console.WriteLine("You see a light ahead, unaware of whats there how do you want to move...");
                Console.WriteLine("1. To go North");
                Console.WriteLine("2. To go South");
                Console.WriteLine("3. To go East");
                Console.WriteLine("4. To go West");
            }
            if (num == 5)
            {

                Console.WriteLine("You see a light ahead, unaware of whats there how do you want to move...");
                Console.WriteLine("1. To go North");
                Console.WriteLine("2. To go South");
                Console.WriteLine("3. To go East");
                Console.WriteLine("4. To go West");
            }
            if (num == 6)
            {

                Console.WriteLine("You see a light ahead, unaware of whats there how do you want to move...");
                Console.WriteLine("1. To go North");
                Console.WriteLine("2. To go South");
                Console.WriteLine("3. To go East");
                Console.WriteLine("4. To go West");
            }
          
        }

        
    }
}

  

