using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms;


public class Menu : App
{
    List<Machine> yourTeam = new() { null, null, null, null, null };
    Player player;
    List<Machine> allMachines = new();
    Shop shop;
    Game game;
    int screenId = 0;

    public Menu()
    {
        AddAllMachines();
        player = new Player(10, yourTeam);
        shop = new Shop(this);
        game = new Game(this, player, allMachines);
    }
    public override void OnFrame(bool isDown, PointF cursor)
    {
        if (screenId == 0)
        {
            screenId = shop.startShop(isDown, cursor, screenId, yourTeam, player);
        }
        else if (screenId == 1)
        {
            game.startGame(isDown, cursor, screenId);
        }
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

}