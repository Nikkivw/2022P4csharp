    List<string> birds = new List<string>() {"Duif", "Roodborsje" };
    birds.Add("Uil");
    birds.Add("Kraai");
    birds.Add("Papagaai");

    birds.Remove("Hond");
    
    List<string> birds2 = new List<string>();
    birds2.Add("meeuw");
    birds2.Add("Arend");
 
    foreach (string bird in birds)
    {
        Console.WriteLine(bird);
    }

    Console.ReadLine();