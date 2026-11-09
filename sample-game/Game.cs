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
        Texture2D explosion = Graphics.LoadTexture("../../../../assets/graphics/fwompie.png");
        Sound coinSFX = Audio.LoadSound("../../../../assets/audio/coin.wav");
        Sound targetSFX = Audio.LoadSound("../../../../assets/audio/target.ogg");
        Music bgm = Audio.LoadMusic("../../../../assets/audio/country.mp3");
        Font font = Text.LoadFont("../../../../assets/fonts/klasikap/KLASIKAP.ttf");

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("sex the game");
            Window.SetSize(600, 600);

            string cwd = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine($"CWD: {cwd}");
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);

            if (Audio.IsPlaying(bgm) == false)
            {
                Audio.Play(bgm);
            }

            if(Input.IsKeyboardKeyPressed(KeyboardKey.C) == true)
            {
                Audio.Play(coinSFX);
            }

            if (Input.IsKeyboardKeyPressed(KeyboardKey.T) == true)
            {
                Audio.Play(targetSFX);
            }

            Graphics.Draw(explosion, Vector2.Zero);

            Text.Size = 16;
            Text.Font = font;
            Text.Color = Color.Red;
            Text.Draw("MY NAME JEFF!!!!!!!!!!", Window.Size / 2);
        }
    }

}
