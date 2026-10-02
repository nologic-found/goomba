class GoombaAni
{
    private Character character;
    private int frame;
    private int animDuration;
    private int pauseDuration;

    public GoombaAni(Character character, int frame = 30, int animDuration = 100, int pauseDuration = 750)
    {
        this.character = character;
        this.frame = frame;
        this.animDuration = animDuration;
        this.pauseDuration = pauseDuration;
    }

    public void runFrame()
    {
        for (int i = frame; i >= 1; i--)
        {
            Console.Clear();
            character.Move();
            character.DrawSprites();
            Thread.Sleep(animDuration);
        }

    }
    public void StartAni()
    {
        runFrame();
        character.ChangeDirection();

        // Wait for a little bit
        Thread.Sleep(pauseDuration);
        runFrame();

        // Reset direction
        character.ChangeDirection();
    }
}

