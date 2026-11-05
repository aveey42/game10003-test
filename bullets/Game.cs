// Include the namespaces (code libraries) you need below.
using bullets;
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
        Vector2 target;
        Vector2 player;
        Bullet[] bullets = new Bullet[9];
        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Bullets");
            Window.SetSize(400, 400);

            target = Window.Size / 2;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.OffWhite);
            player = Input.GetMousePosition();
            float radius = 20;

            if (Input.IsMouseButtonDown(MouseButton.Left) == true)
            {
                target = Input.GetMousePosition();
            }

            if (Input.IsKeyboardKeyDown(KeyboardKey.Space) == true)
            {
                // angle to target?

                Vector2 vectorPlayer2Target = target - player;
                float y = vectorPlayer2Target.Y;
                float x = vectorPlayer2Target.X;
                // RADIANS!
                float anglePlayerToTarget = MathF.Atan2(y,x);

                float spreadDegrees = 65;
                float spreadRadians = spreadDegrees / 360 * MathF.Tau;

                Draw.LineSize = 1;
                Draw.LineColor = Color.Blue;
                for (int i = 0; i < bullets.Length; i++)
                {
                    float percent = i / (float) bullets.Length;
                    float angle = anglePlayerToTarget - spreadRadians / 2 + spreadRadians * percent;
                    Vector2 shotDirection = new Vector2(MathF.Cos(angle), MathF.Sin(angle));
                    bullets[i].Setup(player, player + shotDirection * 100);
                }
            }

            Draw.LineColor = Color.Black;
            Draw.FillColor = Color.Black;
            Draw.Circle(player, radius);

            Draw.LineSize = 3;
            Draw.LineColor = Color.Red;
            Draw.FillColor = Color.OffWhite;
            Draw.Line(target - Vector2.UnitX * radius, target + Vector2.UnitX * radius);        // UnitX = (1,0) , UnitY = (0,1)
            Draw.Circle(target, radius);
        }
    }

}
