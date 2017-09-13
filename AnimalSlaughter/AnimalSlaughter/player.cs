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
        double myRotation;
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
            myRotation = 0;
            

        }

        public void update()
        {
            myKeys = Keyboard.GetState();
            //Vector2 mousePos = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            double musx = Convert.ToDouble( Mouse.GetState().X);
            double musy = Convert.ToDouble(Mouse.GetState().Y);
            myRotation = Math.Atan2(musy,musx);
            userInput(myKeys);
        }

        public void draw(SpriteBatch spritebatch)
        {
           // spritebatch.Draw(myMainSprite,myMovement,Color.White);
           
            spritebatch.Draw(myMainSprite, new Rectangle((int)myMovement.X, (int)myMovement.Y, myMainSprite.Width, myMainSprite.Height), null, Color.White, (float)myRotation, new Vector2(myMainSprite.Width / 2, myMainSprite.Height / 2), SpriteEffects.None, 0);
        }

        public void userInput(KeyboardState keyInputs)
        {
            Keyboard.GetState();
            
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
                myMovement.X += myMoveSpeed;
            }
        }
    }
}
