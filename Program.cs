// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(House.wood_needed); // affichera 3
Console.WriteLine(House.stone_needed); // affichera 3


Village myVillage = new Village("Marianne la créatrice du monde");
myVillage.getName(); // affichera Marianne le createur
Console.WriteLine(myVillage.getName());
Console.WriteLine(myVillage.listHouse.Length);


myVillage.addHouse(new House());
myVillage.addHouse(new House());
myVillage.addHouse(new House());
myVillage.addHouse(new House());
myVillage.addHouse(new House());
Console.WriteLine(myVillage.listHouse.Length); // affichera 3



Console.WriteLine(myVillage.villageois); // affichera 30
