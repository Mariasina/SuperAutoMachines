public class CNCPlasmaCutter: Machine{
    public CNCPlasmaCutter(){
        this.name = "Corte a Plasma CNC";
        this.level = 1;
        this.experience = 1;
        this.tier = 6;
        this.atack = 6;
        this.health = 8;
    }

    public CNCPlasmaCutter(int level, int experience, int atack, int health){
        this.name = "Corte a Plasma CNC";
        this.level = level;
        this.experience = experience;
        this.tier = 6;
        this.atack = atack;
        this.health = health;
    }
}