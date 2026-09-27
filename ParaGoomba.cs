class ParaGoomba : Goomba
{
    private string[] paraGoombaSprite;
    public ParaGoomba(int speed = 1) : base(speed)
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

    public override void DrawSprites()
    {
        for (int i = 0; i < paraGoombaSprite.Length; i++)
        {
            Console.WriteLine(paraGoombaSprite[i]);
        }
    }

    /*
    By default this will move right unless the bool changeDirection is equal to true
    */
    public override void Move()
    {
        if (!changeDirection)
        {
            // Moves right: Add whitespace(s) infront of each string in paraGoombaSprite
            for (int i = 0; i < paraGoombaSprite.Length; i++)
            {
                paraGoombaSprite[i] = new string(' ', speed) + paraGoombaSprite[i];
            }
        }
        else
        {
            for (int i = 0; i < paraGoombaSprite.Length; i++)
            {
                // Moves left: Removes starting character(s) in the string
                paraGoombaSprite[i] = paraGoombaSprite[i].Substring(speed);
            }
        }

    }
}