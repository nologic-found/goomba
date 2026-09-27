using System;

class Goomba
{
    private string[] goombaSprite;


    protected bool changeDirection = false;
    protected int speed;


    // Default constructor
    public Goomba()
    {
        goombaSprite = new string[10];

        goombaSprite[0] = @"        ________        ";
        goombaSprite[1] = @"       /         \      ";
        goombaSprite[2] = @"      /  /\    /\ \     ";
        goombaSprite[3] = @"     /   | |  | |  \    ";
        goombaSprite[4] = @"    /  _^------^_   \   ";
        goombaSprite[5] = @"   |_________________|  ";
        goombaSprite[6] = @"         /    \         ";
        goombaSprite[7] = @"   ____ |      |____    ";
        goombaSprite[8] = @"  /____| ====  |_____\  ";
        goombaSprite[9] = @"                        ";
    }



    public Goomba(int speed = 2)
        : this()
    {
        this.speed = speed;
    }

    // Print each string from goombaSprite
    public virtual void DrawSprites()
    {
        for (int i = 0; i < goombaSprite.Length; i++)
        {
            Console.WriteLine(goombaSprite[i]);
        }
    }

    /*
    By default this will move right unless the bool changeDirection is equal to true
    */
    public virtual void Move()
    {
        if (!changeDirection)
        {
            // Moves right: Add whitespace(s) infront of each string in goombaSprite
            for (int i = 0; i < goombaSprite.Length; i++)
            {
                goombaSprite[i] = new string(' ', speed) + goombaSprite[i];
            }
        }
        else
        {
            for (int i = 0; i < goombaSprite.Length; i++)
            {
                // Moves left: Removes starting character(s) in the string
                goombaSprite[i] = goombaSprite[i].Substring(speed);
            }
        }

    }

    public void ChangeDirection()
    {
        changeDirection = !changeDirection;
    }

}