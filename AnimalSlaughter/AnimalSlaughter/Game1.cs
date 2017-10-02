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
        
        GraphicsDeviceManager graphics;
        SpriteBatch SpriteBatch;
        player ThePlayer;
        Goat AGoat;
        Undead_Wolf AnUndead_Wolf;
        Texture2D PlayerMainSprite;
        Texture2D TheGoatSprite;
        Texture2D TheUndeadWolfSprite;
        Dictionary<string, Texture2D> myTextureDictionary = new Dictionary<string, Texture2D>();
        public Dictionary<string, Texture2D> getMyTextureDictionary { get => myTextureDictionary; }

        public static Game1 Game1Acess;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.PreferredBackBufferWidth = 2048;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1024;   // set this value to the desired height of your window
            Content.RootDirectory = "Content";

            Game1Acess = this;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            SpriteBatch = new SpriteBatch(GraphicsDevice);
            PlayerMainSprite = Content.Load<Texture2D>("PlayerMain/Player");
            TheGoatSprite = Content.Load<Texture2D>("Animals/Goat");
            TheUndeadWolfSprite = Content.Load<Texture2D>("Animals/Undead_Wolf");
            //player. = Content.Load<Texture2D>("Projectiles/Health_Bar");

            ThePlayer = new player(512, 512, 7, 10, PlayerMainSprite, new Vector2(100, 100));
            AGoat = new Goat();
            AnUndead_Wolf = new Undead_Wolf();
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            ThePlayer.update();
            AGoat.Update(ThePlayer.getMyMovement);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            SpriteBatch.Begin();
            IsMouseVisible = true;
            // TODO: Add your drawing code here
            ThePlayer.draw(SpriteBatch);
            SpriteBatch.Draw(TheGoatSprite, AGoat.getMyMovement, Color.White);
            SpriteBatch.Draw(TheUndeadWolfSprite, AnUndead_Wolf.getMyMovement, Color.White);
            SpriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
