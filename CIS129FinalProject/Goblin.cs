using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Goblin
    {
        private int _enemyDamage;
        private int _enemyHealth;


        

        public Goblin(int enemyHealth)
        {
            _enemyHealth = enemyHealth;

        }

        public void GobAttack(Wizart wizart)
        {
            wizart.TakeDamage(3, "Cleave");
        }
        public void GoblinAlive()
        {
            bool isAlive;

            if (_enemyHealth > 0) {
                isAlive= true;
            }
            else
            {
                isAlive= false;
            }
        }
    }
}
