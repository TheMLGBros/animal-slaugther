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

        enum Gamestates { startMenu, gamePlay, pause, shop, options, betweenLevels, win }//options will include:Gore setting & Sound...
        GraphicsDeviceManager graphics;
        SpriteBatch SpriteBatch;
        player ThePlayer;
        Texture2D PlayerMainSprite;
        List<bullet> globalBulletList;
            
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
            globalBulletList = new List<bullet>();
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

            PlayerMainSprite = Content.Load<Texture2D>("player/player_holdingPistol");
            ThePlayer = new player(new Weapons(10,100,PlayerMainSprite,new Vector2(0,0)),100,7,10,PlayerMainSprite,new Vector2(100,100), globalBulletList);
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
            ThePlayer.update();
            for(int i = globalBulletList.Count-1; i>=0; i--)
            {
                if(globalBulletList[i].isAlive)
                {
                    globalBulletList[i].update();
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
            ThePlayer.draw(SpriteBatch);
            for (int i = globalBulletList.Count-1; i >= 0; i--)
            {
                if (globalBulletList[i].isAlive)
                {
                    globalBulletList[i].draw(SpriteBatch);
                }

            }

            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
