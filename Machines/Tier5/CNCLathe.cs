public class CNCLathe: Machine{
    public CNCLathe(){
        this.name = "Torno CNC";
        this.level = 1;
        this.experience = 1;
        this.tier = 5;
        this.atack = 5;
        this.health = 8;
    }

    public CNCLathe(int level, int experience, int atack, int health){
        this.name = "Torno CNC";
        this.level = level;
        this.experience = experience;
        this.tier = 5;
        this.atack = atack;
        this.health = health;
    }
}