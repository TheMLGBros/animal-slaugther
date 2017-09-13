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
    class bullet
    {
        float myMoveSpeed;
        int myDamage;
        double myRotation;
        Vector2 myPosition;
        KeyboardState myKeys;
        Texture2D myMainSprite;
        Rectangle myHitbox;
       public bool isAlive;

        public bullet(Vector2 aPosition, double aRotation, float aMoveSpeed, int aDamage, Texture2D aMainSprite, Rectangle aHitBox)
        {
            myPosition = aPosition;
            myMoveSpeed = aMoveSpeed;
            myDamage = aDamage;
            myMainSprite = aMainSprite;
            myHitbox = aHitBox;
            isAlive = true;
            myRotation = aRotation;
        }

        public void update()
        {/*- (float)Math.PI / 2)*/
            Vector2 dirV = new Vector2((float)Math.Cos(myRotation) , (float)Math.Sin(myRotation)); // calculates the direction that the bullet is going in
            myPosition += dirV * myMoveSpeed; //makes it go forward

            myHitbox.X = (int)myPosition.X;
            myHitbox.Y = (int)myPosition.Y;
        }

        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(myMainSprite,myHitbox,Color.Yellow);
        }
    }
}
