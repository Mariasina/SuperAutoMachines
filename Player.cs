using System.Collections.Generic;

public class Player{
    public int coins { get; set; }
    public int health { get; set; }
    public int trophies { get; set; }
    public List<Machine> currTeam { get; set; }

    public Player(int coins, List<Machine> currTeam){
        this.coins = coins;
        this.health = 5;
        this.trophies = 0;
        this.currTeam = currTeam;
    }
}