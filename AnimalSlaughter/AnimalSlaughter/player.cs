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
        int myHp,myDamage,myWeapon;
        float myMoveSpeed;
        double myRotation;
        Vector2 myPosition;
        KeyboardState myKeys;
        Texture2D myMainSprite;
        List<bullet> myBulletList;
        bool isAlive, canShoot;


        public player(int someWeapon ,int someHp,float someMoveSpeed, int someDamage, Texture2D aMainSprite, Vector2 aPosition, List<bullet>aBulletList)
        {
            myHp = someHp;
            myMoveSpeed = someMoveSpeed;
            myMainSprite = aMainSprite;
            myDamage = someDamage;
            myPosition = aPosition;
            myWeapon = someWeapon;
            myRotation = 0;
            myBulletList = aBulletList;
            isAlive = true;
            canShoot = true;
        }

        public void update()
        {
            myKeys = Keyboard.GetState();
            //Vector2 mousePos = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            double musx = Convert.ToDouble( Mouse.GetState().X) - myPosition.X;
            double musy = Convert.ToDouble(Mouse.GetState().Y) - myPosition.Y;
            myRotation = Math.Atan2(musy,musx);
            userInput(myKeys);
        }

        public void draw(SpriteBatch spritebatch)
        {
           // spritebatch.Draw(myMainSprite,myMovement,Color.White);
           
            spritebatch.Draw(myMainSprite, new Rectangle((int)myPosition.X, (int)myPosition.Y, myMainSprite.Width, myMainSprite.Height), null, Color.White, (float)myRotation,new Vector2(myMainSprite.Width / 2, myMainSprite.Height / 2), SpriteEffects.None, 0);
        }

        public void userInput(KeyboardState keyInputs)
        {
            Keyboard.GetState();
            
            if(keyInputs.IsKeyDown(Keys.W))
            {
                myPosition.Y -= myMoveSpeed;
            }
            if (keyInputs.IsKeyDown(Keys.S))
            {
                myPosition.Y += myMoveSpeed;
            }
            if (keyInputs.IsKeyDown(Keys.A))
            {
                myPosition.X -= myMoveSpeed;
            }

            if (keyInputs.IsKeyDown(Keys.D))
            {
                myPosition.X += myMoveSpeed;
            }

            if (keyInputs.IsKeyDown(Keys.Space))
            {
                 if(canShoot)
                {
                 myBulletList.Add(new bullet(myPosition,myRotation,10+myMoveSpeed,myDamage,myMainSprite,new Rectangle((int)myPosition.X,(int)myPosition.Y,30,30)));
                }
                canShoot = false;
            }
            else
            {
                canShoot = true;
            }
        }
    }
}
