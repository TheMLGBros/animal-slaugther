using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSlaughter
{
    public class EnemyParent
    {
        public int myHealth;
        public int myDamage;

        public int GetHealth { get => myHealth; }
        public int GetDamage { get => myDamage; }
    }
}
