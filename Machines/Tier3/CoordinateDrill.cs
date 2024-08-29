public class CoordinateDrill: Machine{
    public CoordinateDrill(){
        this.name = "Furadeira de Coordenada";
        this.level = 1;
        this.experience = 1;
        this.tier = 3;
        this.atack = 3;
        this.health = 5;
    }

    public CoordinateDrill(int level, int experience, int atack, int health){
        this.name = "Furadeira de Coordenada";
        this.level = level;
        this.experience = experience;
        this.tier = 3;
        this.atack = atack;
        this.health = health;
    }
}