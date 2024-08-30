using System;
using System.Collections.Generic;
using System.Drawing;

public class Game
{
    private App app;
    List<Machine> allMachines = new();
    List<Machine> yourRoundTeam = new();
    List<Machine> enemyRoundTeam = new(){ null, null, null, null, null };
    Player player;


    public Game(App app, Player player, List<Machine> allMachines)
    {
        this.app = app;
        this.player = player;
        this.allMachines = allMachines;
        GenerateEnemy();
        yourRoundTeam = player.currTeam;
    }

    public void startGame(bool isDown, PointF cursor, int screenId)
    {
        app.DrawText("Seu time", Color.Black, new RectangleF(200, 350, 400, 20));
        int teamCountX = 50;
        for (int i = yourRoundTeam.Count - 1; i >= 0; i--)
        {
            var item = yourRoundTeam[i];
            var pieceRect = new RectangleF(teamCountX, 400, 200, 200);
            if (item != null)
                app.DrawPiece(pieceRect, item.atack, item.health, item.experience, item.tier, item.name);
            else app.DrawEmpty(pieceRect);

            teamCountX += 150;
        }

        app.DrawText("Time inimigo" , Color.Black, new RectangleF(1300, 350, 400, 20));
        int enemyCountX = 1140;
        for (int i = 0; i < enemyRoundTeam.Count; i++)
        {
            var item = enemyRoundTeam[i];
            var pieceRect = new RectangleF(enemyCountX, 400, 200, 200);
            if (item != null)
                app.DrawPiece(pieceRect, item.atack, item.health, item.experience, item.tier, item.name);
            else app.DrawEmpty(pieceRect);

            enemyCountX += 150;
        }
    }

    public void Atack(){
        while(!CheckNull(yourRoundTeam) && !CheckNull(enemyRoundTeam)){
            -
        }
    }

    public void GenerateEnemy()
    {
        Random generator = new Random();

        for (int i = 0; i < generator.Next(3, 5); i++)
            enemyRoundTeam[i] = allMachines[generator.Next(0, 14)];
    }

    public bool CheckNull(List<Machine> list){
        foreach (var item in list)
        {
            if(item != null)
                return false;
        }
        return true;
    }
}