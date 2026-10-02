using System;

class Goomba : Character
{
    private string[] goombaSprite;


    private bool changeDirection = false;
    private int speed = 1;
    private int pos;

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
        goombaSprite[8] = @"  /____|  ====  |_____\  ";
        goombaSprite[9] = @"                        ";
    }



    public Goomba(int speed = 2)
        : this()
    {
        this.speed = speed;
    }

    // Print each string from goombaSprite
    public void DrawSprites()
    {
        for (int i = 0; i < goombaSprite.Length; i++)
        {
            Console.WriteLine(new string(' ',pos) + goombaSprite[i]);
        }
    }

    /*
    By default this will move right unless the bool changeDirection is equal to true
    */
    public void Move()
    {
        if (!changeDirection)
            pos += speed;
        else
            pos = Math.Max(0, pos - speed);

    }


    public void ChangeDirection()
    {
        changeDirection = !changeDirection;
    }

}