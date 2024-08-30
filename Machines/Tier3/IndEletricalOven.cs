public class IndEletricalOven: Machine{
    public IndEletricalOven(){
        this.name = "Forno Idustrial Elétrico";
        this.level = 1;
        this.experience = 1;
        this.tier = 3;
        this.atack = 4;
        this.health = 3;
    }

    public IndEletricalOven(int level, int experience, int atack, int health){
        this.name = "Forno Idustrial Elétrico";
        this.level = level;
        this.experience = experience;
        this.tier = 3;
        this.atack = atack;
        this.health = health;
    }
}