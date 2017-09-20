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
    class Undead_Wolf : Npc
    {
        public Undead_Wolf()
        {
            myHp = 100;
            myDamage = 7;
            myMoveSpeed = 3.5f;
            myMovement = new Vector2(Game1.Game1Acess.Window.ClientBounds.Width / 2, Game1.Game1Acess.Window.ClientBounds.Height / 2);
            Game1.Game1Acess.getMyTextureDictionary.Add("TheUndeadWolfSprite", myMainSprite);
        }
    }
}
