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
        int ArrowAnchorX = 300;
        int ArrowAnchorY = 400;
        int ArrowX;
        int ArrowY;
        // Line Count and Coords
        int LineCount = 0;
        
        int LineCoordX = 240;
        int LineCoordY = 200;

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

            // Pants
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.LightGray);
            Draw.Rectangle(230, 500, 140, 50);
            Draw.Rectangle(330, 500, 40, 250);
            Draw.Rectangle(230, 500, 40, 250);

            // Left Foot
            Draw.Triangle(180, 750, 230, 700, 230, 750);
            //Right Foor
            Draw.Triangle(420, 750, 370, 700, 370, 750);

            // Outlines
            Draw.SetLineSize(1);
            Draw.Line(180, 750, 270, 750);
            Draw.Line(180, 750, 230, 700);
            Draw.Line(230, 700, 230, 500);
            Draw.Line(230, 500, 370, 500);
            Draw.Line(370, 500, 370, 700);
            Draw.Line(370, 700, 420, 750);
            Draw.Line(420, 750, 330, 750);
            Draw.Line(330, 750, 330, 550);
            Draw.Line(330, 550, 270, 550);
            Draw.Line(270, 550, 270, 750);
            Draw.Line(270, 750, 180, 750);


            // Skirt
            Draw.SetFillColor(Color.Black);
            Draw.Triangle(300, 395, 170, 600, 430, 600);
            // Legs
            Draw.SetFillColor(Color.Yellow);
            Draw.Rectangle(229, 600, 41, 31);
            Draw.Rectangle(329, 600, 41, 31);
            // Socks
            Draw.SetFillColor(Color.White);
            Draw.Rectangle(229, 630, 41, 71);
            Draw.Rectangle(329, 630, 41, 71);

            // For loop drawing lines on socks

            //for (LineCount = 0; LineCount < 8; LineCount++)
            //{
            //    Draw.Line(LineCoordX - 140, LineCoordY, LineCoordX - 140, LineCoordY + 10);
            //    LineCoordX += 5;
            //}
            //LineCoordX = 335;
            //LineCoordY = 630;
            //for (LineCount = 7; LineCount < 14; LineCount++)
            //{
            //    Draw.Line(LineCoordX, LineCoordY, LineCoordX, LineCoordY + 10);
            //    LineCoordX += 5;
            //}


            // Draw Base Neck

            // Remove outlines
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Yellow);

            // Neck
            Draw.Triangle(310, 300, 320, 310, 310, 310);
            Draw.Triangle(290, 300, 280, 310, 290, 310);
            Draw.Square(290, 290, 20);

            // Outlines
            Draw.SetLineSize(1);
            Draw.Line(290, 290, 290, 300);
            Draw.Line(310, 290, 310, 300);
            Draw.Line(310, 300, 320, 310);
            Draw.Line(290, 300, 280, 310);

            //Draw Head
            //Draw.Capsule(280, 245, 320, 245, 50);
            Draw.Capsule(300, 230, 300, 245, 50);

            // Draw Base Torso

            // Remove outlines
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Red);

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

            // Collar
            Draw.SetLineSize(0);
            Draw.SetFillColor(Color.Yellow);
            Draw.Triangle(270, 310, 330, 310, 300, 340);
            Draw.SetLineSize(1);
            Draw.Line(300, 340, 270, 310);
            Draw.Line(300, 340, 330, 310);
            Draw.Line(320, 310, 330, 310);
            Draw.Line(270, 310, 280, 310);

            // Redraw shirt outlines
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

            for (LineCount = 0; LineCount < 13; LineCount++)
            {
                Draw.Line(LineCoordX, LineCoordY, LineCoordX, LineCoordY +30);
                LineCoordX += 10;
            }

            ArrowSetup();
        }
        void ArrowSetup()
        {
            // Set Left Arrow origin
            ArrowX = ArrowAnchorX - 140;
            ArrowY = ArrowAnchorY - 10;

            // Draw Arrow Left
            Draw.SetLineSize(0);
            Draw.Rectangle(ArrowX, ArrowY + 20, -30, +20);
            Draw.Triangle(ArrowX - 30, ArrowY, ArrowX - 60, ArrowY + 30, ArrowX - 30, ArrowY + 60);

            // Draw outlines if i have time

            // if mouseposition on arrow && mouseclick == down TorsoType -1

            // Set Right Arrow origin

            ArrowX = ArrowAnchorX + 140;
            ArrowY = ArrowAnchorY - 10;

            // Draw Arrow Right
            Draw.SetLineSize(0);
            Draw.Rectangle(ArrowX, ArrowY + 20, +30, +20);
            Draw.Triangle(ArrowX + 30, ArrowY, ArrowX + 60, ArrowY + 30, ArrowX + 30, ArrowY + 60);

            // if mouseposition on arrow && mouseclick == down TorsoType +1
        }
    }

}
