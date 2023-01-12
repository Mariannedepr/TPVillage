public class Village {
    private string name;
    private Ressources myRessources;   //les objets fonctionnent comme des types 
    //comme elle est de type ressource elle peut utiliser les méthodes de la classe Ressource

    public House chefHome;    //chefHome peut maintenant utiliser les méthodes de la classe house
    public int villageois = 0;
    public House []listHouse;   //c'est un tab
    public Mine Mine;

//constructeur de la classe 
    public Village(string name){
        this.name = name;
        this.myRessources = new Ressources();   //instanciation 
        this.chefHome = new House();
        this.villageois = House.villageois;   //comme mon attribut villageois est public dans ma classe House on peut le call ici
        this.listHouse = new House [1];    
        this.listHouse[0] = this.chefHome;
        this.Mine = new Mine();    //Creation d'une mine (affichage de "Mine created")
       
    }

    public string getName(){
        return this.name;
    }

    public int getWood(){
        return myRessources.getWood();
    }

    public int getStone(){
        return myRessources.getStone();
    }

//ajout de maisons dans notre tableau listHouse
    //pour ajouter un élément à un tableau : il faut appeler le tableau
    //on va donc créer un nouveau tableau qui aurait pour taille le nombre d'éléments
    //on attribue les éléments de l'ancien tableau (ici la maison du chef)
    //appeler le tableau pour lui attribuer un nouvel element

    private void addHouse(House maison){
       House []listHouse2 = new House [listHouse.Length +1];   //on incrémente la taille de notre tableau
        for(int i = 0; i <listHouse.Length; i++){    //on parcourt tt les indexs de l'ancien tableau
            listHouse2[i] = listHouse[i];     //on attribue le contenu de l'ancien tableau au nouveau et ce pour toutes les cases de l'ancien tableau
        }

        listHouse2[listHouse2.Length -1] = maison;    //j'appelle mon nouveau tableau
        //le -1 il sert à appeler le dernier index de mon tableau 

        //on va réattribuer la valeur de notre nouveau tableau à notre ancien tableau :
        listHouse = listHouse2;
        this.villageois = listHouse.Length * House.villageois;
    }

        public void mineStone(int nbvillageois){


            //verif si pas trop de villageois par rapport au nb de villageois de base dans le village
            //else if verif si assez de pierres 
            //verif si assez de pierre (mine.wood_cost * villageois < wood) 
            //si pas asseez : ressource insufisantes
            //si c'est ok on pioche

            if (nbvillageois > this.villageois){
                Console.WriteLine("ya pas assez de monde sorry");
            }   else if (Mine.stone_cost * nbvillageois > getStone()  || Mine.wood_cost * nbvillageois >  getWood() ){
                Console.WriteLine("ya pas assez de ressources sorry");
            }   else {
                    myRessources.useStone(Mine.stone_cost * nbvillageois);
                    myRessources.useWood(Mine.wood_cost * nbvillageois);
                    myRessources.addStone(Mine.mineStone(nbvillageois));   //on récup notre méthode addStone qui ajoute des pierres 
                    //addStone prend en paramètre un nombre qui devient ici la méthode mineStone
            }  
    }

}