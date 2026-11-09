using System;
using System.Collections.ObjectModel;
using System.Numerics;

namespace MohawkGame2D;

public class character
{
    Texture2D spritesheet = Graphics.LoadTexture("../../../../");
    Vector2 characterPosition;
    int currentFrame;
    int[] currentAnimation = animDown;
    int facingDirection;
    int characterRow = 0;

    // Game data
    //// Base frames
    //const int downBaseFrame = 0;
    //const int upBaseFrame = 3;
    //const int sideBaseFrame = 6;
    // Frame Counts, removes necessity for base frame variables above ^^^
    static readonly int[] animDown = [0, 1, 2, 1];
    static readonly int[] animUp   = [3, 4, 5, 4];
    static readonly int[] animSide = [6, 7, 6, 7];
    // Size
    const int width = 16;
    const int height = 16;

    public void Update()
    {
        if (Input.IsKeyboardKeyPressed(KeyboardKey.W))
        {
            currentAnimation = animUp;
        }
        if (Input.IsKeyboardKeyPressed(KeyboardKey.S))
        {
            currentAnimation = animDown;
        }
        if (Input.IsKeyboardKeyPressed(KeyboardKey.A))
        {
            currentAnimation = animSide;
        }
        if (Input.IsKeyboardKeyPressed(KeyboardKey.D))
        {
            currentAnimation = animSide;
        }


        if (Input.IsKeyboardKeyPressed(KeyboardKey.Space))
        {
            currentFrame += 1;
            currentFrame %= currentAnimation.Length;         // does same thing as the statement below
            //if (currentFrame >= downFrameCount)
            //    currentFrame = 0;
        }

        if (Input.IsKeyboardKeyPressed(KeyboardKey.Z))
        {
            characterRow += 1;      // selects row used
        }

        Vector2 position = Window.Size / 2;
        int spriteFrame = currentAnimation[currentFrame];
        int subsetX = spriteFrame * width;
        int subsetY = characterRow * height;
        Vector2 subsetOrigin = new Vector2(subsetX, subsetY);
        Vector2 subsetSize = new Vector2(width, height);

        Graphics.Scale = 4;
        Graphics.DrawSubset(spritesheet, position, subsetOrigin, subsetSize);
    }
}
