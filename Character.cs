namespace GettingStarted;

public class Character
{
    public Race Race { get; private set; }
    public int Armor { get; private set; }
    public Character(Race race)
    {
        Race = race;
        //Armor = (int)race ;

        Armor = race switch
        {
            Race.Elf => 30,
            Race.Ork => 40,
            Race.Terran => 20,
            _ => throw new Exception("Неизвестная раса")
        };

    }
    public int Health { get; private set; } = 100;


    public void hit(int damage)
    {
        Health = Math.Max(Health - damage, 0);
    }
}