using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._01.Character;
using TextRPG._02.Field;

namespace TextRPG._00.MainGame
{
    internal class MainGame
    {
        private static MainGame m_Instance;
        private Character m_Player;
        private Field m_Field;

        private MainGame()
        {
            m_Player = default;
            m_Field = default;
        }

        public static MainGame Instance()
        {
            if (m_Instance == null)
            {
                m_Instance = new MainGame();
            }

            return m_Instance;
        }

        public Character GetPlayer() => m_Player;

        public void Game()
        {
            while(true)
            {
                Console.WriteLine("    TextRPG    ");
                Console.WriteLine("===============");
                Console.WriteLine("1.게임시작 2.종료");

                int iselect = int.Parse(Console.ReadLine());

                switch(iselect)
                {
                    case 1:
                        CreatePlayer();
                }
            }
        }
    }
}
