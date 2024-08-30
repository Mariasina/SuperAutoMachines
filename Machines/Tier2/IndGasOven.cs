public class IndGasOven: Machine{
    public IndGasOven(){
        this.name = "Forno Industrial a Gás";
        this.level = 1;
        this.experience = 1;
        this.tier = 2;
        this.atack = 1;
        this.health = 3;
    }

    public IndGasOven(int level, int experience, int atack, int health){
        this.name = "Forno Industrial a Gás";
        this.level = level;
        this.experience = experience;
        this.tier = 2;
        this.atack = atack;
        this.health = health;
    }
}