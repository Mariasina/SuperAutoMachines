public class Lathe: Machine{
    public Lathe(){
        this.name = "Torno";
        this.level = 1;
        this.experience = 1;
        this.tier = 4;
        this.atack = 5;
        this.health = 3;
    }

    public Lathe(int level, int experience, int atack, int health){
        this.name = "Torno";
        this.level = level;
        this.experience = experience;
        this.tier = 4;
        this.atack = atack;
        this.health = health;
    }
}