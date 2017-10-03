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
    class Weapons
    {
        int myDamage, myAmmo;
        float myBulletSpeed;
        double myRotation;
        bool canShoot = true;

        Vector2 myPosition;
        Texture2D myWeaponSprite, myBulletSprite;
        List<Bullet> myBulletList;
        MouseState myMouseInput;
        player myOwner;
        public Weapons(int someDamage, int someAmmo, double someRotation, float aBulletSpeed, List<Bullet> aBulletList, Texture2D someBulletSprite, player aOwner, Texture2D aWeaponSprite, Vector2 aPosition)
        {
            myDamage = someDamage;
            myAmmo = someAmmo;
            myWeaponSprite = aWeaponSprite;
            myPosition = aPosition;
            myRotation = someRotation;
            myBulletList = aBulletList;
            myBulletSprite = someBulletSprite;
            myBulletSpeed = aBulletSpeed;
            myOwner = aOwner;
        }
        public void update(double aRotation)
        {
           /* myPosition.X = player.myHandPosition.X;
            myPosition.Y = player.myHandPosition.Y;*/
            myPosition = player.myHandPosition;
            controls(myMouseInput);
            myRotation = aRotation;
        }
        public void draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(myWeaponSprite, myPosition, new Rectangle(30,30,5,5), Color.Red, (float)myRotation + (float)Math.PI / 2, new Vector2(myWeaponSprite.Width / 2, myWeaponSprite.Height), 1f, SpriteEffects.None, 1f);
            spriteBatch.Draw(myWeaponSprite, myPosition, null,Color.White,(float)myRotation+(float)Math.PI/2,new Vector2(myWeaponSprite.Width/2,myWeaponSprite.Height),1f,SpriteEffects.None,1f);
        }
        private void controls(MouseState someMouseInput)
        {
            someMouseInput = Mouse.GetState();
            if (someMouseInput.LeftButton == ButtonState.Pressed)
            {
                if (canShoot)
                {
                    myBulletList.Add(new Bullet(myPosition, myRotation, 10 + myBulletSpeed, myDamage, myBulletSprite, new Rectangle((int)myPosition.X, (int)myPosition.Y, 8, 32)));
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
