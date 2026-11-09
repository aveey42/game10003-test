// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        Texture2D graphic = Graphics.LoadTexture("");
        Sound sfx1 = Audio.LoadSound("");
        Sound sfx2 = Audio.LoadSound("");
        Font font = Text.LoadFont("");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("sex the game");
            Window.SetSize(600, 600);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
        }
    }

}
