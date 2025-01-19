using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;

namespace BounceRing.BounceRing
{
    public class Match : Microsoft.Xna.Framework.Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private int isPaused = 0;

        public Match()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = false;
        }
        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override async void Update(GameTime gameTime)
        {
            KeyboardInput();

            base.Update(gameTime);
        }

        private void KeyboardInput()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.Escape))
            {
                Pause();
                isPaused = 1;
            }
        }

        private void Pause()
        {
            /*static void exit()
            {
                
            }*/
            if (isPaused == 1)
            {
                if (/*exit()*/Keyboard.GetState().IsKeyDown(Keys.Escape))
                {
                    isPaused = 0;
                    var mainMenu = new MainMenu();
                    mainMenu.Run();
                    Exit();
                }
            }
        }
    }
}
