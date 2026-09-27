class GoombaAni
{
    private Goomba g;
    private int frame = 30;
    private int animDuration = 50;
    private int pauseDuration = 1000;


    public GoombaAni(Goomba g) { this.g = g; }

    public void MoveRight()
    {

        for (int i = 1; i < frame; i++)
        {
            Console.Clear();
            g.DrawSprites();
            Thread.Sleep(animDuration);
            g.Move();
        }


    }

    public void MoveLeft()
    {
        for (int j = frame; j >= 1; j--)
        {
            Console.Clear();
            g.DrawSprites();
            Thread.Sleep(animDuration);
            g.Move();
        }

    }
    public void StartAni()
    {
        MoveRight();
        
        // Wait for a little bit
        g.ChangeDirection();
        Thread.Sleep(pauseDuration);

        MoveLeft();

        // Reset direction
        g.ChangeDirection();

    }


}

