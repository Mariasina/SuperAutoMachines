public class Hammer: Machine{
    public Hammer(){
        this.name = "Martelo";
        this.level = 1;
        this.experience = 1;
        this.tier = 1;
        this.atack = 2;
        this.health = 3;
    }

    public Hammer(int level, int experience, int atack, int health){
        this.name = "Martelo";
        this.level = level;
        this.experience = experience;
        this.tier = 1;
        this.atack = atack;
        this.health = health;
    }
}