class GoombaAni
{
    private Character character;
    private int frame;
    private int animDuration;
    private int pauseDuration;

    public GoombaAni(Character character, int frame = 30, int animDuration = 100, int pauseDuration = 1000)
    {
        this.character = character;
        this.frame = frame;
        this.animDuration = animDuration;
        this.pauseDuration = pauseDuration;
    }
    public void runFrame()
    {
        for (int j = frame; j >= 1; j--)
        {
            Console.Clear();
            character.DrawSprites();
            Thread.Sleep(animDuration);
            character.Move();
        }

    }
    public void StartAni()
    {
        runFrame();

        character.ChangeDirection();

        // Wait for a little bit
        character.DrawSprites();
        Thread.Sleep(pauseDuration);

        runFrame();

        // Reset direction
        character.ChangeDirection();

    }


}

