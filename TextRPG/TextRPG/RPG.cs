using System;
using TextRPG._00.MainGame;

namespace TextRPG
{
    public class RPG
    {
        public static void Main(string[] args)
        {
            MainGame maingame = MainGame.Instance();

            maingame.Game();

            maingame.CheckPlayer();
        }
    }
}