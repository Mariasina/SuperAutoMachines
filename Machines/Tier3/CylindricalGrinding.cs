public class CylindricalGrinding: Machine{
    public CylindricalGrinding(){
        this.name = "Retífica Cilíndrica";
        this.level = 1;
        this.experience = 1;
        this.tier = 3;
        this.atack = 2;
        this.health = 6;
    }

    public CylindricalGrinding(int level, int experience, int atack, int health){
        this.name = "Retífica Cilíndrica";
        this.level = level;
        this.experience = experience;
        this.tier = 3;
        this.atack = atack;
        this.health = health;
    }
}