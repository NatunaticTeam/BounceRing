using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using BounceRing;
using System.Diagnostics;

namespace BounceRing
{
    public class MainMenu : Game
    {
        Texture2D spr_exitDialog;
        Texture2D ballTexture;
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public int exitDiagOpen;

        Vector2 ballPosition;
        Vector2 exitDiagPos;
        float ballSpeed;

        public MainMenu()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            ballPosition = new Vector2(_graphics.PreferredBackBufferWidth / 2,
                                   _graphics.PreferredBackBufferHeight / 2);
            ballSpeed = 100f;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            ballTexture = Content.Load<Texture2D>("ball");
            spr_exitDialog = Content.Load<Texture2D>("dialog-box");

            // TODO: use this.Content to load your game content here
        }

        protected override async void Update(GameTime gameTime)
        {
            


            KeyboardInput();
            GamePadInput();

            base.Update(gameTime);
        }

        private void GamePadInput()
        {
            Vector2 lDirection = GamePad.GetState(PlayerIndex.One).ThumbSticks.Left;

            Debug.WriteLine(lDirection);

            if (GamePad.GetState(PlayerIndex.One).DPad.Up == ButtonState.Pressed)
            {
            
            }

            
            
            
            

        }

        private void KeyboardInput()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Enter))
            {
                var match = new BounceRing.match();
                match.Run();
            }
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            #region Items to Draw

            _spriteBatch.Draw(
                ballTexture,
                ballPosition,
                null,
                Color.White,
                0f,
                new Vector2(ballTexture.Width / 2, ballTexture.Height / 2),
                Vector2.One,
                SpriteEffects.None,
                0f
            );

            

            #endregion
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
