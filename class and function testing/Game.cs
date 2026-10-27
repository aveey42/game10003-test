// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    /// 
    public class Game
    {
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>

        //CharacterHead head = new CharacterHead();  // tells computer to allocate memory for the head and store it.
        public void Setup()
        {
            Window.SetTitle("Avery's Micro Character Creator");
            Window.SetSize(600, 800);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.LightGray);

            // Draw Neck




            // Draw Base Torso

            // Remove outlines
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Blue);

            // Torso Outline
            Draw.Rectangle(230, 330, 140, 170);
            Draw.Rectangle(240, 310, 120, 140);
            Draw.Triangle(240, 310, 200, 330, 240, 330);
            Draw.Triangle(360, 310, 360, 330, 400, 330);

            // Arms
            Draw.Rectangle(200, 330, 30, 160);
            Draw.Rectangle(370, 330, 30, 160);

            // Hands
            Draw.SetLineColor(Color.Black);
            Draw.SetLineSize(1);
            Draw.SetFillColor(Color.Yellow);
            Draw.Rectangle(195, 490, 40, 30);
            Draw.Rectangle(365, 490, 40, 30);

            // Outlines

            //Shirt Top + Shoulders
            Draw.Line(240, 310, 360, 310);
            Draw.Line(240, 310, 200, 330);
            Draw.Line(360, 310, 400, 330);

            // Left Arm
            Draw.Line(200, 330, 200, 490);
            Draw.Line(230, 355, 230, 490);
            Draw.Line(200, 490, 230, 490);

            // Right Arm
            Draw.Line(400, 330, 400, 490);
            Draw.Line(370, 355, 370, 490);
            Draw.Line(370, 490, 400, 490);

            // Shirt Bottom
            Draw.Line(235, 500, 365, 500);

            // Sleeve Cuffs
            Draw.SetLineSize(1);
            Draw.SetFillColor(Color.Magenta);
            Draw.Rectangle(200, 480, 30, 10);
            Draw.Rectangle(370, 480, 30, 10);

        }
    }

}
