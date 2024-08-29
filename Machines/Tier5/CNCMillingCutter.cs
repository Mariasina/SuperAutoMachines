public class CNCMillingCutter: Machine{
    public CNCMillingCutter(){
        this.name = "Fresa CNC";
        this.level = 1;
        this.experience = 1;
        this.tier = 5;
        this.atack = 8;
        this.health = 4;
    }

    public CNCMillingCutter(int level, int experience, int atack, int health){
        this.name = "Fresa CNC";
        this.level = level;
        this.experience = experience;
        this.tier = 5;
        this.atack = atack;
        this.health = health;
    }
}