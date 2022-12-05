using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS129FinalProject
{
    public class Orc
    {
        private int _enemyDamage;
        private int _enemyHealth;
        private bool isAlive;
        public Orc(int enemyHealth)
        {
            _enemyHealth = enemyHealth;

        }

        public void OrcAttack(Wizart wizart)
        {
            wizart.TakeDamage(3, "Body Slam");
        }
        public void OrcAlive()
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
