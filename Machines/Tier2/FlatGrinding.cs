public class FlatGrinding: Machine{
    public FlatGrinding(){
        this.name = "Retífica Plana";
        this.level = 1;
        this.experience = 1;
        this.tier = 2;
        this.atack = 4;
        this.health = 2;
    }

    public FlatGrinding(int level, int experience, int atack, int health){
        this.name = "Retífica Plana";
        this.level = level;
        this.experience = experience;
        this.tier = 2;
        this.atack = atack;
        this.health = health;
    }
}