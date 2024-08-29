public class ColumnDrill: Machine{
    public ColumnDrill(){
        this.name = "Furadeira de Coluna";
        this.level = 1;
        this.experience = 1;
        this.tier = 2;
        this.atack = 3;
        this.health = 5;
    }

    public ColumnDrill(int level, int experience, int atack, int health){
        this.name = "Furadeira de Coluna";
        this.level = level;
        this.experience = experience;
        this.tier = 2;
        this.atack = atack;
        this.health = health;
    }
}