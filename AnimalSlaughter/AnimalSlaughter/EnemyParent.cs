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
    public class EnemyParent
    {
        public int myHealth;
        public int myDamage;
        public float mySpeed;
        public Vector2 myPosition;
        public Texture2D mySprite;

        public int GetHealth { get => myHealth; }
        public int GetDamage { get => myDamage; }
        public float GetSpeed { get => mySpeed; }
        public Vector2 GetPosition { get => myPosition; }
        public Texture2D GetSprite { get => mySprite; }
    }
}
