public class Mine{
    static public int gain_stone = 10;
    static public int stone_cost = 2;
    static public int wood_cost = 1;
    public Mine(){
        Console.WriteLine("Mine created");
    }
    public int mineStone(int nbvillageois){
      return nbvillageois * gain_stone;
    }

}