public class Ressources {
    private int woods;
    private int stones;

    //constructeur de la classe
    public Ressources(){   //constructeur paramétrique
        this.woods = 10;
        this.stones = 10;
    }

    public int getWood(){
        return woods;
    }

    public int getStone(){
        return stones;
    }

//deux méthodes pour utiliser nos ressources :
    public void useWood(int nb){
        if(woods >= nb){
            woods -= nb;
        }
        else Console.WriteLine("Plus assez de bois la famille");
        
    }
    public void useStone(int nb){
        if(stones >= nb){
            stones -= nb;
        }
        else Console.WriteLine("Plus assez de pierres la famille");
        
    }

    public void addStone(int nbr){
        stones += nbr;
    }

}