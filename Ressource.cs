public class Ressources {
    private int woods;
    private int stones;
    public int level;
    private int wood_max;
    private int stones_max;

    //constructeur de la classe
    public Ressources(){   //constructeur paramétrique
        this.woods = 10;
        this.stones = 10;
        this.level = 1;
        this.wood_max = 250;
        this.stones_max = 250;
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
        else Console.WriteLine("Plus assez de bois dans la réserve");
        
    }
    public void useStone(int nb){
        if(stones >= nb){
            stones -= nb;
        }
        else Console.WriteLine("Plus assez de pierres dans la réserve");
        
    }

    public void addStone(int nbr){
        stones += nbr;
        //on vérif si notre collecte de pierre est sup au taux max par niveau
        //alors notre tas de pierre il prend la valeur du taux max
        //comme ça on peut pas dépasser la valeur du taux max par niveau
        if(getStone() > stones_max){
            stones = stones_max;
        }
    }

    public void addWood(int nbr){
        woods += nbr;
        if(getWood()> wood_max){
            woods = wood_max;
        }
    }

    public void upgrade(){
        //coutera 80% de nos ressources max 
        //augmentera les ressources max * 2
        //vérif si les ressources sont à 250 pour passer au niveau 2
        //si oui on enleve 80% de nos ressources
        //au niveau suivant les ressources max doublent
        if(getWood() >= this.wood_max * 80 / 100 && getStone() >= this.stones_max * 80 / 100){

            this.wood_max *= 2;
            this.stones_max *= 2;
            Console.WriteLine("Bravo tu passes au niveau supérieur !");
            level++; 
        }
        else {
            Console.WriteLine("t'es pauvre va couper du bois");
        }
    }

}