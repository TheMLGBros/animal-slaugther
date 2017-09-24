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
        public static player playeracess;
        float myMoveSpeed;
        double myRotation;
        public static Vector2 myPosition, myHandPosition;
        bool myLife, myWalkingAnimationIsPlaying;
        int myHp, myDamage;


        Weapons myWeapon;

        KeyboardState myKeys;
        MouseState myMouse;
        Texture2D myMainSprite, myWalkAnimation;

        //Walking animation variables
        private int myWalkRows { get; set; }
        private int myWalkColumns { get; set; }
        private int myCurrentWalkFrame;
        private int myTotalWalkFrames;
        private int myTimeSinceLastWalkFrame = 0;
        private int myMillisecondsPerWalkFrame = 400;


        public player(Weapons someWeapon, int someHp, float someMoveSpeed, int someDamage,int someWalkRows, int someWalkColumns, int someTotalWalkFrames, Texture2D aMainSprite, Vector2 aPosition,Vector2 aHandPosition, List<Bullet> aBulletList, Texture2D aWalkAnimation)
        {
            myHp = someHp;
            myMoveSpeed = someMoveSpeed;
            myMainSprite = aMainSprite;
            myDamage = someDamage;
            myPosition = aPosition;
            myWeapon = someWeapon;
            myRotation = 0;
            myWalkAnimation = aWalkAnimation;
            myHandPosition = aHandPosition;
            myLife = true;

            //Walking animation variables
            myWalkColumns = someWalkColumns;
            myWalkRows = someWalkRows;
            myTotalWalkFrames = someWalkColumns * someWalkRows;
            myCurrentWalkFrame = someTotalWalkFrames;
            myWalkingAnimationIsPlaying = false;
        }

        public void update(GameTime aGameTime)
        {
            myKeys = Keyboard.GetState();
            //Vector2 mousePos = new Vector2(Mouse.GetState().X, Mouse.GetState().Y);
            double musx = Convert.ToDouble( Mouse.GetState().X) - myPosition.X;
            double musy = Convert.ToDouble(Mouse.GetState().Y) - myPosition.Y;
            myRotation = Math.Atan2(musy,musx);
            userInput(myKeys, myMouse);
            myWeapon.update(myRotation);

            //Animtaion handling
            myTimeSinceLastWalkFrame += aGameTime.ElapsedGameTime.Milliseconds;
            if (myTimeSinceLastWalkFrame > myMillisecondsPerWalkFrame)
            {
                myTimeSinceLastWalkFrame -= myMillisecondsPerWalkFrame;


                myCurrentWalkFrame++;
                myTimeSinceLastWalkFrame = 0;
                if (myCurrentWalkFrame > myTotalWalkFrames-1)
                {
                    myCurrentWalkFrame = 0;
                }
            }
        }

        public void draw(SpriteBatch spritebatch)
        {
            // spritebatch.Draw(myMainSprite,myMovement,Color.White);
            myWeapon.draw(spritebatch);
            //spritebatch.Draw(myMainSprite, new Rectangle((int)myPosition.X, (int)myPosition.Y, myMainSprite.Width, myMainSprite.Height), null, Color.White, (float)myRotation,new Vector2(myMainSprite.Width / 2, myMainSprite.Height / 2), SpriteEffects.None, 0);


            //animation
            int tempWidth = myWalkAnimation.Width / myWalkColumns;
            int tempHeight = myWalkAnimation.Height / myWalkRows;
            int tempRow = (int)((float)myCurrentWalkFrame / myWalkColumns);
            int tempColumn = myCurrentWalkFrame % myWalkColumns;
            Rectangle tempSourceRectangle = new Rectangle(tempWidth * tempColumn, tempHeight * tempRow, tempWidth, tempHeight);

            //Rectangle destinationRectangle = new Rectangle((int)Position.X-enemyTexture.Width/2, (int)Position.Y - enemyTexture.Height / 2, width - enemyTexture.Width / 2, height - enemyTexture.Height / 2);
            if(myWalkingAnimationIsPlaying)
            {
            spritebatch.Draw(myWalkAnimation, new Vector2(myPosition.X, myPosition.Y), tempSourceRectangle, Color.White, (float)myRotation+(float)Math.PI/2, new Vector2(tempSourceRectangle.Width/2,tempSourceRectangle.Height/2), 1f, SpriteEffects.None, 0f);
            }
            else
            {
                spritebatch.Draw(myMainSprite, new Vector2(myPosition.X, myPosition.Y), null, Color.White, (float)myRotation + (float)Math.PI / 2, new Vector2(tempSourceRectangle.Width / 2, tempSourceRectangle.Height / 2), 1f, SpriteEffects.None, 0f);
            }
        }

        public void userInput(KeyboardState someKeyInput, MouseState someMouseInput)
        {
            Keyboard.GetState();
            someMouseInput = Mouse.GetState();


            if(someKeyInput.IsKeyDown(Keys.W) || someKeyInput.IsKeyDown(Keys.A) || someKeyInput.IsKeyDown(Keys.S) || someKeyInput.IsKeyDown(Keys.D))
            {
                myWalkingAnimationIsPlaying = true;
            }
            else
            {
                myWalkingAnimationIsPlaying = false;
            }


            if (someKeyInput.IsKeyDown(Keys.W))
            {
                myPosition.Y -= myMoveSpeed;
                myHandPosition.Y -= myMoveSpeed;
            }
            if (someKeyInput.IsKeyDown(Keys.S))
            {
                myPosition.Y += myMoveSpeed;
                myHandPosition.Y += myMoveSpeed;
            }
            if (someKeyInput.IsKeyDown(Keys.A))
            {
                myPosition.X -= myMoveSpeed;
                myHandPosition.X -= myMoveSpeed;
            }
            if (someKeyInput.IsKeyDown(Keys.D))
            {
                myPosition.X += myMoveSpeed;
                myHandPosition.X += myMoveSpeed;
            }
        }
    }
}
