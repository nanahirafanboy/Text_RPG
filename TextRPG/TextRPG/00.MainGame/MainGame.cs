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
    }
}
