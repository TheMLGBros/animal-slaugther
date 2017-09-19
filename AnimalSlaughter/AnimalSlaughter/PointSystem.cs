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
    class PointSystem
    {
        public bool myYouHaveWon = false;
        int myPoints;
        int myPointsToWin;
        public PointSystem(int somePointsToWin)
        {
            myPointsToWin = somePointsToWin;
        }
        public void UpdateScore(int somePointsToAdd)
        {
            AddScore(somePointsToAdd);
            WinCheck(myPoints);
        }
        private void AddScore(int aScoreToAdd)
        {
            myPoints += aScoreToAdd;
        }
        private void WinCheck(int someScore)
        {
            if (someScore > myPointsToWin)
            {
                myYouHaveWon = true;
                //You win somehow (I haven't figured it out yet)
            }
        }
    }
}
