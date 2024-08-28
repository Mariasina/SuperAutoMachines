public class Tredmill: Machine{
    public Tredmill(){
        this.name = "Esteira";
        this.level = 1;
        this.experience = 1;
        this.tier = 1;
        this.atack = 3;
        this.health = 1;
    }

    public Tredmill(int level, int experience, int atack, int health){
        this.name = "Esteira";
        this.level = level;
        this.experience = experience;
        this.tier = 1;
        this.atack = atack;
        this.health = health;
    }
}