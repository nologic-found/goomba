class ParaGoomba : Character
{
    private string[] paraGoombaSprite;
    private bool changeDirection = false;

    private int speed = 1;
    private int pos;
    public ParaGoomba(int speed = 1)
    {
        paraGoombaSprite = new string[10];

        paraGoombaSprite[0] = @"              ________  ";
        paraGoombaSprite[1] = @"             /        \ ";
        paraGoombaSprite[2] = @"            /  \    /  \ ";
        paraGoombaSprite[3] = @"           /   |    |   \ ";
        paraGoombaSprite[4] = @"_________ /  -^------^-  \ _________";
        paraGoombaSprite[5] = @"\_       |________________|       _/";
        paraGoombaSprite[6] = @"  \_           /    \           _/  ";
        paraGoombaSprite[7] = @"    \____ ____|      |____ ____/";
        paraGoombaSprite[8] = @"         /____\ ==== /____\ ";
        paraGoombaSprite[9] = @"                             ";
    }

    public void DrawSprites()
    {
        for (int i = 0; i < paraGoombaSprite.Length; i++)
        {
            Console.WriteLine(new string(' ',pos) + paraGoombaSprite[i]);
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