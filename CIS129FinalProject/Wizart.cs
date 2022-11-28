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


        public Wizart(int wizartHp, int wizartMp)
        {
            _wizartHp = wizartHp;
            _wizartMp = wizartMp;
            

        }   

        public void UseFireball()
        {
            if(_wizartMp < 3)
            {
                Console.WriteLine("Not enough MP");
            }
            else
            {
                
                Console.WriteLine($"Wizart mp{_wizartMp} and did {_fireballDamage} damage");
                _fireballDamage = -5;
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
        public void UseFlee()
        {
            Random random = new Random();
            int fleeChance = random.Next(1, 3);
            if(fleeChance % 2 == 0)
            {
                Console.WriteLine("Wizart fled");
            }
            else
            {
                Console.WriteLine("Failed to Escape!!");
            }

        }

      
    }

   
}
