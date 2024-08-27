using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


public class Menu : App
{
    bool fundiu = false;
    bool clicked = false;
    RectangleF rect1 = RectangleF.Empty;
    RectangleF rect2 = RectangleF.Empty;
    RectangleF rect3 = RectangleF.Empty;
    List<Machine> allMachines;
    public override void OnFrame(bool isDown, PointF cursor)
    {
        AddAllMachines();
        GenerateStore();

        if (rect1.Contains(cursor) && rect2.Contains(cursor) && !isDown)
            fundiu = true;

        if (!fundiu)
        {
            DrawText("Your Team", Color.Black, new RectangleF(150, 20, 400, 50));
            rect1 = DrawPiece(new RectangleF(50, 100, 200, 200), 1, 3, 1, 1, true, "CNC");
            rect2 = DrawPiece(new RectangleF(300, 100, 200, 200), 2, 4, 2, 1, true, "CNC");
            rect3 = DrawPiece(new RectangleF(550, 100, 200, 200), 2, 4, 2, 1, true, "CNC");

            DrawText("Store", Color.Black, new RectangleF(1360, 20, 400, 50));
            // rect1 = DrawPiece(new RectangleF(1250, 100, 200, 200), 1, 3, 1, 1, true, "CNC");
            // rect1 = DrawPiece(new RectangleF(1500, 100, 200, 200), 1, 3, 1, 1, true, "CNC");
            // rect2 = DrawPiece(new RectangleF(1750, 100, 200, 200), 2, 4, 2, 1, true, "CNC");
        }
        else
        {
            DrawPiece(new RectangleF(50, 50, 200, 200), 3, 5, 3, 1, true, "CNC");
        }

        if (!clicked)
        {
            clicked = DrawButton(new RectangleF(400, 400, 200, 100), "Iniciar");
            if (clicked)
                MessageBox.Show("Clicou");
        }
    }

    public void AddAllMachines()
    {
        allMachines.Add(new Hammer());
        allMachines.Add(new Screwdriver());
    }

    public void GenerateStore()
    {
        Random generator = new Random();

        for (int i = 0; i < 3; i++)
        {
            Machine currMachine = allMachines[generator.Next(0, 1)];
            System.Console.WriteLine(currMachine.name);
            RectangleF rect = DrawPiece(new RectangleF(1250, 100, 200, 200), currMachine.atack, currMachine.health, currMachine.experience, currMachine.tier, true, currMachine.name);
        }
    }
}