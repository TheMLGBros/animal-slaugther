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
<<<<<<< HEAD
        int Hp, MoveSpeed,Damage;
        Vector2 Movement;
        KeyboardState InputKeys;
        Texture2D MainSpirte;


        public player(int hp,int moveSpeed, int damage, Texture2D mainSpirte, Vector2 movement, KeyboardState inputKeys)
        {
            Hp = hp;
            MoveSpeed = moveSpeed;
            MainSpirte = mainSpirte;
            Damage = damage;
            Movement = movement;
            InputKeys = inputKeys;
=======
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

>>>>>>> Fredrik-Changes
        }

        public void update()
        {
<<<<<<< HEAD
            userInput(InputKeys);
=======
            userInput(myKeys);
>>>>>>> Fredrik-Changes
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
