using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Banshee
    {
        private int _enemyDamage;
        private int _enemyHealth;
        private bool isAlive;
        public Banshee(int enemyHealth)
        {
            _enemyHealth = enemyHealth;

        }

        public void BansheeAttack(Wizart wizart)
        {
            wizart.TakeDamage(5, "Screech");
        }
        
        public void BansheeBattle(Wizart wizart)
        {
            wizart.Battle("banshee", 8);
        }
        public void BansheeAlive()
        {


            if (_enemyHealth > 0)
            {
                isAlive = true;
            }
            else
            {
                isAlive = false;
            }
        }
    }
}