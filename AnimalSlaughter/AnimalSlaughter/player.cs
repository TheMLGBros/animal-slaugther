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
        }

        public void update()
        {
            userInput(InputKeys);
        }

        public void draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(MainSpirte,Movement,Color.White);
        }

        public void userInput(KeyboardState keyInputs)
        {
            if(keyInputs.IsKeyDown(Keys.W))
            {
                Movement.Y -= MoveSpeed;
            }
            if (keyInputs.IsKeyDown(Keys.S))
            {
                Movement.Y += MoveSpeed;
            }
            if (keyInputs.IsKeyDown(Keys.A))
            {
                Movement.X -= MoveSpeed;
            }

            if (keyInputs.IsKeyDown(Keys.D))
            {
                Movement.Y += MoveSpeed;
            }
        }
    }
}
