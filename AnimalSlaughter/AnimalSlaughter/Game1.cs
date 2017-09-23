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
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Vector2 myPlayerStartPosition= new Vector2(500,800);
        public static Game1 myGame1Acess;
        enum myGamestates { startMenu, gamePlay, pause, shop, options, betweenLevels, win }//options will include:Gore setting & Sound...
        GraphicsDeviceManager graphics;
        SpriteBatch SpriteBatch;
        player myPlayer;
        Texture2D myPlayerMainAnimation, myBasicBullet, myIdlePlayer;
        List<Bullet> myGlobalBulletList;
            
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 2000;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1024;   // set this value to the desired height of your window
            Content.RootDirectory = "Content";
            
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            myGlobalBulletList = new List<Bullet>();
            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            myIdlePlayer = Content.Load<Texture2D>("player/playerIdle");
            myPlayerMainAnimation = Content.Load<Texture2D>("player/playerWalkAnimation");
            myBasicBullet = Content.Load<Texture2D>("bullets/basicBullet");
            myPlayer = new player(new Weapons(10,100,0,0.2f,myGlobalBulletList,myBasicBullet,myPlayer,myBasicBullet,new Vector2(myIdlePlayer.Width/2,myIdlePlayer.Height)),100,7,10,1,4,4,myPlayerMainAnimation, myPlayerStartPosition, new Vector2(myPlayerStartPosition.X+myIdlePlayer.Width/2-20, myPlayerStartPosition.Y+20), myGlobalBulletList,myPlayerMainAnimation);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            myPlayer.update(gameTime);
            for(int i = myGlobalBulletList.Count-1; i>=0; i--)
            {
                if(myGlobalBulletList[i].isAlive)
                {
                    myGlobalBulletList[i].update();
                }
                
            }
            //DJUIOAJOIDWAJIODJKIOAWDJIOJIOWDIOWDJIOWDJIOWDWDJIOAWDJIOWDJAWDIOJWDIOWDJIOWDWDIOJAWDIOJSDKLDAWJSDKWAJILSDAJKSDILAWSMDKAIJLSDAWDJISKDJLAWIKSDLJIAWKSDJILAWKSDJKLAWJIKSD

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
            IsMouseVisible = true;
            // TODO: Add your drawing code here
            myPlayer.draw(SpriteBatch);
            for (int i = myGlobalBulletList.Count-1; i >= 0; i--)
            {
                if (myGlobalBulletList[i].isAlive)
                {
                    myGlobalBulletList[i].draw(SpriteBatch);
                }

            }

            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
