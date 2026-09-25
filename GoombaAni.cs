using System.Net.NetworkInformation;

class GoombaAni
{
    private Goomba g;

    public GoombaAni(Goomba g)
    {
        this.g = g;
    }

    public void StartAni()
    {
        // Durations are in milliseconds
        int frame = 50;
        int animDuration = 50;
        int pauseDuration = 1000;
        // int speed = 2;   

        Goomba g = new Goomba(1);

        // Move right 
        for (int i = 0; i < frame; i++)
        {
            g.DrawSprites();
            Thread.Sleep(animDuration);
            g.Move();
            Console.Clear();
        }

        // Wait for a little bit
        g.DrawSprites();
        Thread.Sleep(pauseDuration);
        Console.Clear();

        // change direction
        g.ChangeDirection();

        // Then move left
        for (int j = frame; j >= 0; j--)
        {
            g.DrawSprites();
            Thread.Sleep(animDuration);
            g.Move();
            Console.Clear();
        }

    }


}

