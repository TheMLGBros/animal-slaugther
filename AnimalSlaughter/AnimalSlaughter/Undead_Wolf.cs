using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSlaughter
{
    public class Undead_Wolf : EnemyParent
    {
        public static List<Undead_Wolf> Warriors = new List<Undead_Wolf>();

        public Undead_Wolf(int aHealth, int aDamage)
        {
            myHealth = aHealth;
            myDamage = aDamage;
        }

        public static void CreateWarrior(int Amount, int aHealth, int aDamage)
        {
            for (int i = 0; i < Amount; i++)
            {
                Warriors.Add(new Undead_Wolf(aHealth, aDamage));
            }
        }

        public void Attack()
        {
            Random myRandomizer = new Random();

            /*while (Player.)
            {

            }*/

        }

        public bool IsDead()
        {
            for (int i = Warriors.Count; i > 0; i--)
            {
                if (Warriors[i - 1].myHealth <= 0)
                {
                    Warriors.Remove(Warriors[i - 1]);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
