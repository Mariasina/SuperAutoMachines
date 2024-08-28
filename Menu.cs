using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Windows.Forms;


public class Menu : App
{
    bool fundiu = false;
    bool clicked = false;
    bool storeMouseDown = false;
    bool needGenerated = true;
    RectangleF rectEmpty = RectangleF.Empty;
    List<Machine> allMachines = new();
    List<Machine> yourTeam = new() { null, null, null, null, null };
    Machine[] store = new Machine[3];
    RectangleF[] storeRects = new RectangleF[3];

    public Menu()
    {
        GenerateStore();
        storeRects[0] = new RectangleF(1250, 100, 200, 200);
        storeRects[1] = new RectangleF(1500, 100, 200, 200);
        storeRects[2] = new RectangleF(1750, 100, 200, 200);
    }

    public override void OnFrame(bool isDown, PointF cursor)
    {
        //Your Team
        DrawText("Your Team", Color.Black, new RectangleF(150, 20, 400, 50));

        for (int i = 0; i < 3; i++)
            CheckColisionEmpty(isDown, cursor, storeRects[i], i);

        int teamCountX = 50;
        int teamCountY = 100;
        foreach (var item in yourTeam)
        {
            if (item != null)
                DrawPiece(new RectangleF(teamCountX, teamCountY, 200, 200), item.atack, item.health, item.experience, item.tier, item.name);
            else DrawEmpty(new RectangleF(teamCountX, teamCountY, 200, 200));

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
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, "CNC");
        }

        //Store
        DrawText("Store", Color.Black, new RectangleF(1360, 20, 400, 50));

        if (needGenerated)
        {
            GenerateStore();
            needGenerated = false;
        }

        var newStoreMouseDown = DrawButton(new RectangleF(1450, 400, 200, 100), "Atualizar");
        if (!newStoreMouseDown && storeMouseDown)
            needGenerated = true;
        storeMouseDown = newStoreMouseDown;

        DrawEmpty(new RectangleF(1250, 100, 200, 200));
        for (int i = 0; i < 3; i++)
            storeRects[i] = DrawPiece(storeRects[i], store[i].atack, store[i].health, store[i].experience, store[i].tier, store[i].name);


        if (!clicked)
        {
            clicked = DrawButton(new RectangleF(850, 900, 200, 100), "Iniciar");
            if (clicked)
                MessageBox.Show("Clicou");
        }
    }

    public void AddAllMachines()
    {
        allMachines.Add(new Hammer());
        allMachines.Add(new Screwdriver());
        allMachines.Add(new Tredmill());
    }

    public void GenerateStore()
    {
        AddAllMachines();
        Random generator = new Random();

        for (int i = 0; i < 3; i++)
            store[i] = allMachines[generator.Next(0, 3)];
    }

    public void CheckColisionEmpty(bool isDown, PointF cursor, RectangleF rect, int storeIndex){
        if(rect.Contains(cursor) && rectEmpty.Contains(cursor) && !isDown){
            for (int i = 0; i < yourTeam.Count(); i++)
            {
                if(yourTeam[i] == null){
                    yourTeam[i] = store[storeIndex];
                    store[storeIndex] = null;
                    break;
                }
            }
        }
    }
}