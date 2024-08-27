public class Screwdriver: Machine{
    public Screwdriver(){
        this.name = "Chave de Fenda";
        this.level = 1;
        this.experience = 1;
        this.tier = 1;
        this.atack = 2;
        this.health = 3;
    }

    public Screwdriver(int level, int experience, int atack, int health){
        this.name = "Chave de Fenda";
        this.level = level;
        this.experience = experience;
        this.tier = 1;
        this.atack = atack;
        this.health = health;
    }
}