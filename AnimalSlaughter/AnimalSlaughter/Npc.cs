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
    class Npc
    {
        public int myHp, myDamage;
        public float myMoveSpeed;
        public double myRotation;
        public Vector2 myMovement;
        public Texture2D myMainSprite;

        public int getMyHp { get; set; }
        public int getMyDamage { get; set; }
        public int getMyWeapon { get; set; }
        public double getMyRotation { get => myRotation; }
        public Vector2 getMyMovement { get => myMovement; }
        public Texture2D getMyMainSprite { get => myMainSprite; }

    }
}
