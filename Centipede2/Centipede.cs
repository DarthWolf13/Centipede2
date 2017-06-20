using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Centipede2
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Centipede : GameEnvironment
    {


        public Centipede()
        {
            Content.RootDirectory = "Content";
        }


        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            screen = new Point(470, 550);
            SetFullScreen(false);

            // TODO: Add game states to GameStateManager here
            gameStateManager.AddGameState("PlayingState", new PlayingState());
            gameStateManager.AddGameState("GameOverState", new GameOverState());
            gameStateManager.SwitchTo("PlayingState");
        }

    }
}
