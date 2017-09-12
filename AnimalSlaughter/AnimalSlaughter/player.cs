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
    class player
    {
        int myHp, myMoveSpeed,myDamage,myWeapon;
        Vector2 myMovement;
        KeyboardState myKeys;
        Texture2D myMainSprite;


        public player(int someWeapon ,int someHp,int someMoveSpeed, int someDamage, Texture2D aMainSprite, Vector2 aMovement)
        {
            myHp = someHp;
            myMoveSpeed = someMoveSpeed;
            myMainSprite = aMainSprite;
            myDamage = someDamage;
            myMovement = aMovement;
            myWeapon = someWeapon;

        }

        public void update()
        {
            userInput(myKeys);
        }

        public void draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(myMainSprite,myMovement,Color.White);
        }

        public void userInput(KeyboardState keyInputs)
        {
            if(keyInputs.IsKeyDown(Keys.W))
            {
                myMovement.Y -= myMoveSpeed;
            }
            if (keyInputs.IsKeyDown(Keys.S))
            {
                myMovement.Y += myMoveSpeed;
            }
            if (keyInputs.IsKeyDown(Keys.A))
            {
                myMovement.X -= myMoveSpeed;
            }

            if (keyInputs.IsKeyDown(Keys.D))
            {
                myMovement.Y += myMoveSpeed;
            }
        }
    }
}
