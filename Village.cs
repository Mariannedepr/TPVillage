public class Village {
    private string name;
    private Ressources myRessources;   //les objets fonctionnent comme des types 
    //comme elle est de type ressource elle peut utiliser les méthodes de la classe Ressource

    public House chefHome;    //chefHome peut maintenant utiliser les méthodes de la classe house
    private int villageois = 0;
 

//constructeur de la classe 
    public Village(){
        this.name = name;
        this.myRessources = new Ressources();   //instanciation 
        this.chefHome = new House();
        this.villageois = House.villageois;   //comme mon attribut villageois est public dans ma classe House on peut le call ici
    }
    public string getName(){
        return name;
    }

    public int getWood(){
        return myRessources.getWood();
    }

    public int getStone(){
        return myRessources.getStone();
    }

    
}