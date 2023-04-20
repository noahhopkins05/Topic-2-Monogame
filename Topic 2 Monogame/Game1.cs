using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Topic_2_Monogame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D yellowCircleTexutre;
        Texture2D blackCircleTexture;
        Texture2D blackRectangleTexture;
        Texture2D blackSquareTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            _graphics.PreferredBackBufferWidth = 800;  
            _graphics.PreferredBackBufferHeight = 600;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            yellowCircleTexutre = Content.Load<Texture2D>("yellow_circle");
            blackCircleTexture = Content.Load<Texture2D>("black_circle");
            blackRectangleTexture = Content.Load<Texture2D>("black_rectangle");
            blackSquareTexture = Content.Load<Texture2D>("black_square");

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            _spriteBatch.Begin();


            _spriteBatch.Draw(yellowCircleTexutre, new Rectangle(150, 0, 450, 450), Color.White);
            _spriteBatch.Draw(blackCircleTexture, new Rectangle(268, 100, 10, 10), Color.White);
            _spriteBatch.Draw(blackCircleTexture, new Rectangle(468, 100, 10, 10), Color.White);
            _spriteBatch.Draw(blackRectangleTexture, new Rectangle(125, 300, 500, 50), Color.White);
            _spriteBatch.Draw(blackSquareTexture, new Rectangle(375, 200, 10, 10), Color.White);


            _spriteBatch.End();


            base.Draw(gameTime);
        }
    }
}