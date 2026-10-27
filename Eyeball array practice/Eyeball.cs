using System;
using System.Numerics;

namespace MohawkGame2D
{
    public class Eyeball
    {
        // Variables Here

        float x;
        float y;

        public void Setup()
        {
            // Randomize Starting Eye
            x = Random.Integer(Window.Width);
            y = Random.Integer(Window.Height);

            //Randomize Eye Color
            irisColor = Random.Color();
        }

        public void Update()
        {
            // Line Parameters. Since Head is simple, they can stay this way. Depending on the type of head used, we have to make them from various shapes, them remove outlines. Since this is a standard circle, this will be unnecessary
            Draw.LineSize = 1;
            Draw.LineColor = Color.Black;
            //Cornea
            Draw.FillColor = Color.White;
            Draw.Circle(x, y, );

        }
    }
}
