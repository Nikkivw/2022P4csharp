class program
{
    static void Main(string[] args)
    {
        RpgCharacter hero = new RpgCharacter();
        Console.WriteLine(hero.name);
        Console.WriteLine(hero.str);
        Console.WriteLine(hero.hp);
        Console.ReadLine();
    }
}

internal class RpgCharacter
{
    internal readonly string name;
    internal int str;
    internal int hp;

    internal RpgCharacter()
    {
        name = "Cloud Strife";
        str = 999;
        hp = 9999;
    }
}
