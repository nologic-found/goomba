using System;

class GoombaAdv : Character
{
    private string[] goombaSpriteLeft;
    private string[] goombaSpriteRight;


    private bool changeDirection = false;
    private bool frameToggle = false;
    private int speed = 1;
    private int pos = 0;

    // Default constructor
    public GoombaAdv(int speed = 1)
    {
        this.speed = speed;

        goombaSpriteLeft = new string[10];

        goombaSpriteLeft[0] = @"     ________  ";
        goombaSpriteLeft[1] = @"    /        \ ";
        goombaSpriteLeft[2] = @"   /  \    /  \ ";
        goombaSpriteLeft[3] = @"  /   |    |   \ ";
        goombaSpriteLeft[4] = @" /  -^------^-  \ ";
        goombaSpriteLeft[5] = @"|________________| ";
        goombaSpriteLeft[6] = @" ____ /    \ ";
        goombaSpriteLeft[7] = @"/____\      |____ ";
        goombaSpriteLeft[8] = @"       ==== /____\ ";
        goombaSpriteLeft[9] = @"                     ";

        goombaSpriteRight = new string[10];

        goombaSpriteRight[0] = @"     ________  ";
        goombaSpriteRight[1] = @"    /        \ ";
        goombaSpriteRight[2] = @"   /  \    /  \ ";
        goombaSpriteRight[3] = @"  /   |    |   \ ";
        goombaSpriteRight[4] = @" /  -^------^-  \ ";
        goombaSpriteRight[5] = @"|________________| ";
        goombaSpriteRight[6] = @"      /    \ ____ ";
        goombaSpriteRight[7] = @" ____|      /____\ ";
        goombaSpriteRight[8] = @"/____\ ====         ";
        goombaSpriteRight[9] = @"                     ";
    }

    // Print each string from goombaSprite
    public virtual void DrawSprites()
    {
        string[] currentFrame = frameToggle ? goombaSpriteLeft : goombaSpriteRight;

        for (int i = 0; i < currentFrame.Length; i++)
        {
            Console.WriteLine(new string(' ', pos) + currentFrame[i]);
        }
    }



    /*
    By default this will move right unless the bool changeDirection is equal to true
    */
    public virtual void Move()
    {
        if (!changeDirection)
            pos += speed;
        else
            pos = Math.Max(0, pos - speed);

        frameToggle = !frameToggle;
    }

    public void ChangeDirection()
    {
        changeDirection = !changeDirection;
    }

}