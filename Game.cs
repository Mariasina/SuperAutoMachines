using System;
using System.Collections.Generic;
using System.Drawing;

public class Game 
{   
    List<Machine> allMachines = new();
    Machine[] enemies = new Machine[5];


    public Game(){
        GenerateEnemy();
    }

    public void startGame(bool isDown, PointF cursor, int screenId, List<Machine> yourTeam, Player player){
        DrawText("Vidas: " + player.health.ToString(), Color.Black, new RectangleF(850, 20, 400, 10));
        DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, "CNC");
    }

    public void AddAllMachines()
    {
        allMachines.Add(new Hammer());
        allMachines.Add(new Screwdriver());
        allMachines.Add(new Tredmill());
        allMachines.Add(new ColumnDrill());
        allMachines.Add(new FlatGrinding());
        allMachines.Add(new IndGasOven());
        allMachines.Add(new CoordinateDrill());
        allMachines.Add(new CylindricalGrinding());
        allMachines.Add(new IndEletricalOven());
        allMachines.Add(new Lathe());
        allMachines.Add(new MillingCutter());
        allMachines.Add(new CNCLathe());
        allMachines.Add(new CNCMillingCutter());
        allMachines.Add(new CNCPlasmaCutter());
    }

    public void GenerateEnemy()
    {
        AddAllMachines();
        Random generator = new Random();

        for (int i = 0; i < 3; i++)
            enemies[i] = allMachines[generator.Next(0, 14)];
    }
}