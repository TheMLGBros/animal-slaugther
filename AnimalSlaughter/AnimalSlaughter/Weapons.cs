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
        Texture2D mySprite;
        Vector2 myPosition;
        public Weapons(int someDamage, int someAmmo, Texture2D aSprite, Vector2 aPosition)
        {
            myDamage = someDamage;
            myAmmo = someAmmo;
            mySprite = aSprite;
            myPosition = aPosition;
        }
        
    }
}
