using System;

class GoombaAdv : Character
{
    private string[] goombaSpriteLeft;
    private string[] goombaSpriteRight;


    private bool changeDirection = false;
    private int speed = 1;


    // Default constructor
    public GoombaAdv()
    {
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



    public GoombaAdv(int speed = 2)
        : this()
    {
        this.speed = speed;
    }

    public void DrawLeft()
    {
        Console.Clear();

        for (int i = 0; i < goombaSpriteLeft.Length; i++)
        {
            // DrawLeft();
            // DrawRight();
            Console.WriteLine(goombaSpriteLeft[i]);
            // Thread.Sleep(20);
            // Console.WriteLine(goombaSpriteRight[i]);
        }
    }

    public void DrawRight()
    {
    //         //     
    //     //     Console.Clear();
    //     //     for (int j = 0; j < goombaSpriteRight.Length; j++)
    //     //     {
    //     //         // DrawLeft();
    //     //         // DrawRight();
    //     //         Console.WriteLine(goombaSpriteRight[j]);
    //     //         // Thread.Sleep(20);
    //     //         // Console.WriteLine(goombaSpriteRight[i]);
    //     //     }
    }

    // Print each string from goombaSprite
    public virtual void DrawSprites()
    {
    
        DrawLeft();
        DrawRight();

    }



    /*
    By default this will move right unless the bool changeDirection is equal to true
    */
    public virtual void Move()
    {
        if (!changeDirection)
        {
            // Moves right: Add whitespace(s) infront of each string in goombaSprite
            for (int i = 0; i < goombaSpriteLeft.Length; i++)
            {
                goombaSpriteLeft[i] = new string(' ', speed) + goombaSpriteLeft[i];
                goombaSpriteRight[i] = new string(' ', speed + 1) + goombaSpriteRight[i];

            }
        }
        else
        {
            for (int i = 0; i < goombaSpriteLeft.Length; i++)
            {
                // Moves left: Removes starting character(s) in the string
                goombaSpriteLeft[i] = goombaSpriteLeft[i].Substring(speed);
                goombaSpriteLeft[i] = goombaSpriteLeft[i].Substring(speed - 1);
            }
        }

    }

    public void ChangeDirection()
    {
        changeDirection = !changeDirection;
    }

}