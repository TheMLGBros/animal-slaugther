using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace AnimalSlaughter
{
    public class Undead_Wolf : EnemyParent
    {
        Random MyRandomizer = new Random();

        public static List<Undead_Wolf> Wolves = new List<Undead_Wolf>();

        public Undead_Wolf(int aHealth, int aDamage, Vector2 aPosition)
        {
            myHealth = aHealth;
            myDamage = aDamage;
            mySpeed = MyRandomizer.Next(1, 2);
            myPosition = aPosition;
        }

        public static void CreateWarrior(int Amount, int aHealth, int aDamage)
        {
            Random MyRandomizer = new Random();

            for (int i = 0; i < Amount; i++)
            {
                int tempRandomizer = MyRandomizer.Next(0, 3);

                Vector2 tempWest = new Vector2(400, MyRandomizer.Next(384, 576));
                Vector2 tempEast = new Vector2(1600, MyRandomizer.Next(384, 576));
                Vector2 tempNorth = new Vector2(MyRandomizer.Next(800, 1120));
                Vector2 tempSouth = new Vector2(MyRandomizer.Next(800, 1120), 400);

                if (tempRandomizer == 0)
                {
                    Wolves.Add(new Undead_Wolf(aHealth, aDamage, tempWest));
                }
                else if (tempRandomizer == 1)
                {
                    Wolves.Add(new Undead_Wolf(aHealth, aDamage, tempEast));
                }
                else if (tempRandomizer == 2)
                {
                    Wolves.Add(new Undead_Wolf(aHealth, aDamage, tempNorth));
                }
                else if (tempRandomizer == 3)
                {
                    Wolves.Add(new Undead_Wolf(aHealth, aDamage, tempSouth));
                }
            }
        }

        public void Update()
        {
            Random myRandomizer = new Random();

                //while (!player.playeracess.IsDead())
                //{
                    if (myPosition.X > player.GetPosition.X)
                    {
                        myPosition.X -= mySpeed;
                    }
                    if (myPosition.X < player.GetPosition.X)
                    {
                        myPosition.X += mySpeed;
                    }
                    if (myPosition.Y > player.GetPosition.Y)
                    {
                        myPosition.Y -= mySpeed;
                    }
                    if (myPosition.Y < player.GetPosition.Y)
                    {
                        myPosition.Y += mySpeed;
                    }
                //}
            
        }

        public bool IsDead()
        {
            for (int i = Wolves.Count; i > 0; i--)
            {
                if (Wolves[i - 1].myHealth <= 0)
                {
                    Wolves.Remove(Wolves[i - 1]);
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
