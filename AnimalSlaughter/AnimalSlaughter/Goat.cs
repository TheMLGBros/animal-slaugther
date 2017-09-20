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
    class Goat : Npc
    {

        public Goat()
        {
            myHp = 100;
            myDamage = 4;
            myMoveSpeed = 2f;
            myMovement = new Vector2(Game1.Game1Acess.Window.ClientBounds.Width / 2, Game1.Game1Acess.Window.ClientBounds.Height / 2);
        }

        public void Update(Vector2 aPlayerMovement) //TEST
        {
            int tempTimer = 0;
            tempTimer++;
            if (tempTimer % 10 <= 1)
            {
                if (myMovement.X > aPlayerMovement.X)
                {
                    myMovement.X -= myMoveSpeed;
                }
                else if (myMovement.X < aPlayerMovement.X)
                {
                    myMovement.X += myMoveSpeed;
                }
                if (myMovement.Y > aPlayerMovement.Y)
                {
                    myMovement.Y -= myMoveSpeed;
                }
                else if (myMovement.Y < aPlayerMovement.Y)
                {
                    myMovement.Y += myMoveSpeed;
                }
            }
        }
    }
}
