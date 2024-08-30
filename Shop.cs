using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Design;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms;


public class Shop{
    private App app;
    
    bool fundiu = false;
    bool clicked = false;
    bool storeMouseDown = false;
    bool needGenerated = true;
    RectangleF rectEmpty = RectangleF.Empty;
    List<Machine> allMachines = new();
    Machine[] store = new Machine[3];
    RectangleF[] storeRects = new RectangleF[3];
    RectangleF[] currentStoreRects = new RectangleF[3];
    int selectedIndex = -1;

    public Shop(App app)
    {
        this.app = app;
        GenerateStore();
        storeRects[0] = new RectangleF(1250, 100, 200, 200);
        storeRects[1] = new RectangleF(1500, 100, 200, 200);
        storeRects[2] = new RectangleF(1750, 100, 200, 200);
    }
    public int startShop(bool isDown, PointF cursor, int screenId, List<Machine> yourTeam, Player player)
    {
        app.DrawText("Moedas: " + player.coins.ToString(), Color.Black, new RectangleF(700, 20, 400, 10));
        app.DrawText("Vidas: " + player.health.ToString(), Color.Black, new RectangleF(850, 20, 400, 10));

        //Your Team
        app.DrawText("Seu time", Color.Black, new RectangleF(150, 20, 400, 50));

        int teamCountX = 50;
        int teamCountY = 100;
        for (int i = 0; i < yourTeam.Count; i++)
        {
            var item = yourTeam[i];
            var pieceRect = new RectangleF(teamCountX, teamCountY, 200, 200);
            if (item != null)
                app.DrawPiece(pieceRect, item.atack, item.health, item.experience, item.tier, item.name);
            else app.DrawEmpty(pieceRect);

            if (player.coins >= 3)
            {
                CheckColisionEmpty(isDown, cursor, pieceRect, yourTeam, player);
            }

            teamCountX += 250;
            if (teamCountX > 550)
            {
                teamCountX = 170;
                teamCountY = 400;
            }
        }

        if (!fundiu)
        {
            // DrawEmpty(new RectangleF(50, 100, 200, 200));
            // DrawEmpty(new RectangleF(300, 100, 200, 200));
            // DrawEmpty(new RectangleF(550, 100, 200, 200));
            // DrawEmpty(new RectangleF(160, 400, 200, 200));
            // DrawEmpty(new RectangleF(410, 400, 200, 200));
        }
        else
        {
            app.DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, "CNC");
        }

        //Store
        app.DrawText("Loja", Color.Black, new RectangleF(1360, 20, 400, 50));

        if (needGenerated)
        {
            GenerateStore();
            needGenerated = false;
        }

        if (player.coins > 0)
        {
            var newStoreMouseDown = app.DrawButton(new RectangleF(1450, 400, 200, 100), "Atualizar");
            if (!newStoreMouseDown && storeMouseDown)
            {
                needGenerated = true;
                player.coins--;
            }
            storeMouseDown = newStoreMouseDown;
        }
        else
        {
            var newStoreMouseDown = app.DrawButton(new RectangleF(1450, 400, 200, 100), "Sem moedas suficientes");
        }

        selectedIndex = -1;
        for (int i = 0; i < 3; i++)
        {
            app.DrawEmpty(storeRects[i]);
            if (store[i] == null)
                continue;

            currentStoreRects[i] = app.DrawPiece(storeRects[i], store[i].atack, store[i].health, store[i].experience, store[i].tier, store[i].name);
            if (currentStoreRects[i].Location != storeRects[i].Location)
                selectedIndex = i;
        }


        if (!clicked)
        {
            clicked = app.DrawButton(new RectangleF(850, 900, 200, 100), "Iniciar");
            if (clicked)
                return 1;
                
        }
        return 0;
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

    public void GenerateStore()
    {
        AddAllMachines();
        Random generator = new Random();

        for (int i = 0; i < 3; i++)
            store[i] = allMachines[generator.Next(0, 14)];
    }

    public void CheckColisionEmpty(bool isDown, PointF cursor, RectangleF teamRect, List<Machine> yourTeam, Player player)
    {
        if (!teamRect.Contains(cursor) || isDown || selectedIndex == -1)
            return;

        for (int i = 0; i < yourTeam.Count(); i++)
        {
            if (yourTeam[i] != null)
                continue;

            yourTeam[i] = store[selectedIndex];
            player.coins -= 3;
            player.currTeam = yourTeam;
            store[selectedIndex] = null;
            break;
        }
    }
}