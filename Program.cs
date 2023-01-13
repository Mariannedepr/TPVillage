// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Console.WriteLine(House.wood_needed); // affichera 3
// Console.WriteLine(House.stone_needed); // affichera 3


// Village myVillage = new Village("Marianne la créatrice du monde");
// myVillage.getName(); // affichera Marianne le createur
// Console.WriteLine(myVillage.getName());
// Console.WriteLine(myVillage.listHouse.Length);


// myVillage.addHouse(new House());
// myVillage.addHouse(new House());
// myVillage.addHouse(new House());
// myVillage.addHouse(new House());
// myVillage.addHouse(new House());
// Console.WriteLine(myVillage.listHouse.Length); // affichera 3

// Console.WriteLine(myVillage.villageois); // affichera 30


// Console.WriteLine(Mine.gain_stone); // affichera 10
// Console.WriteLine(Mine.stone_cost); // affichera 2
// Console.WriteLine(Mine.wood_cost); // affichera 1

// Village myVillage = new Village("Marianne la créatrice");
// myVillage.mineStone(50); // Affichera: Il n'y a pas assez de villageois
// Console.WriteLine(myVillage.getStone()); // Affichera 10
// Console.WriteLine(myVillage.getWood());// Affichera 10
// myVillage.mineStone(6); // Affichera : Il n'y a pas assez de ressources
// Console.WriteLine(myVillage.getStone()); // Affichera 10
// Console.WriteLine(myVillage.getWood()); // Affichera 10
// myVillage.mineStone(5);
// myVillage.mineStone(5);
// Console.WriteLine(myVillage.getStone()); // Affichera 90
// Console.WriteLine(myVillage.getWood()); // Affichera 0
// myVillage.mineStone(5); // Affichera : Il n'y a pas assez de ressources


// Console.WriteLine(Forest.gain_wood); //affichera 10
// Console.WriteLine(Forest.stone_cost); //affichera 2
// Console.WriteLine(Forest.wood_cost); //affichera 1
// Forest test = new Forest();

Village myVillage = new Village("Victor le createur");
Console.WriteLine(myVillage.getName());

myVillage.buildHouse (1); 
Console.WriteLine(myVillage.listHouse.Length);


Console.WriteLine(myVillage.getWood());  //7
Console.WriteLine(myVillage.getStone());  //7
Console.WriteLine(myVillage.villageois);  //ya 20 pélo

myVillage.mineStone(1);
Console.WriteLine(myVillage.getStone());  //15
Console.WriteLine(myVillage.getWood()); //6

myVillage.cutWood(1);
Console.WriteLine(myVillage.getStone()); //13
Console.WriteLine(myVillage.getWood());  //15


myVillage.mineStone(3);
Console.WriteLine(myVillage.getStone());  //37 
Console.WriteLine(myVillage.getWood());   //12 

myVillage.cutWood(3);
Console.WriteLine(myVillage.getStone());  //31
Console.WriteLine(myVillage.getWood());   //39

myVillage.mineStone(15);
Console.WriteLine(myVillage.getStone());  //151
Console.WriteLine(myVillage.getWood());   //24

myVillage.cutWood(15);
Console.WriteLine(myVillage.getStone());   //121
Console.WriteLine(myVillage.getWood());    //159

myVillage.mineStone(20);
Console.WriteLine(myVillage.getStone());  
Console.WriteLine(myVillage.getWood());   

myVillage.cutWood(20);
Console.WriteLine(myVillage.getStone());   
Console.WriteLine(myVillage.getWood()); 


myVillage.upgradeRessources();
Console.WriteLine(myVillage.getStone()); 
Console.WriteLine(myVillage.getWood());

Console.WriteLine(myVillage.getStone()); 
Console.WriteLine(myVillage.getWood());

myVillage.upgradeRessources();
Console.WriteLine(myVillage.getLevel());
myVillage.lookAround();

Console.WriteLine(myVillage.getStone()); 
Console.WriteLine(myVillage.getWood());

