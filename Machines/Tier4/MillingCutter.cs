public class MillingCutter: Machine{
    public MillingCutter(){
        this.name = "Fresa";
        this.level = 1;
        this.experience = 1;
        this.tier = 4;
        this.atack = 4;
        this.health = 5;
    }

    public MillingCutter(int level, int experience, int atack, int health){
        this.name = "Fresa";
        this.level = level;
        this.experience = experience;
        this.tier = 4;
        this.atack = atack;
        this.health = health;
    }
}