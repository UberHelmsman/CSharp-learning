public class Character
{

    public int Health { get; private set; } = 100;


    public void hit(int damage)
    {
        Health = Math.Max(Health-damage, 0);
    }
}