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


    int screenId = 0;

    public Menu()
    {
        player = new Player(10, yourTeam);
    }
    public override void OnFrame(bool isDown, PointF cursor)
    {
        if (screenId == 0)
        {

            Shop shop = new Shop();
            shop.startShop(isDown, cursor, screenId, yourTeam, player);
        }
        else if (screenId == 1)
        {
            Game game = new Game();
            game.startGame(isDown, cursor, screenId, yourTeam, player);
        }
    }

}