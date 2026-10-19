// Include the namespaces (code libraries) you need below.
using Raylib_cs;
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
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Pac-Man Ghosts");
            Window.SetSize(400, 400);
            Window.TargetFPS = 60;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            DrawGhost(350, 90, Color.Red);
            DrawGhost(250, 130,Color.Cyan);
            DrawGhost(100,300, Color.Green);
            DrawGhost(320,320, Color.Magenta);
        }
        
        //Draw Ghost
        void DrawGhost(float x, float y, Color color)
        {
            // Ghost Body
            Draw.SetFillColor(color);
            Draw.SetLineSize(0);
            Draw.Circle(x, y, 30);
            Draw.Rectangle(x - 30, y, 60, 30);
            Draw.Triangle(x - 30, y + 30, x - 20, y + 50, x - 10, y + 30); //correct
            Draw.Triangle(x - 10, y + 30, x, y + 50, x + 10, y + 30);
            Draw.Triangle(x + 10, y + 30, x + 20, y + 50, x + 30, y + 30);

            // Ghost Cornea
            Draw.FillColor = Color.White;
            Draw.SetLineSize(1);
            Draw.Circle(x - 15, y, 10);
            Draw.Circle(x + 15, y, 10);

            // Ghost Pupil
            Draw.FillColor = Color.Black;
            Draw.Circle(x - 15, y, 5);
            Draw.Circle(x + 15, y, 5);

        }
    }

}
