using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._01.Character;
using TextRPG._01.Character._00.Player;
using TextRPG._02.Field;
using TextRPG._99.ETC;

namespace TextRPG._00.MainGame
{
    internal class MainGame
    {
        private static MainGame m_Instance;
        private Character m_Player;
        private Field m_Field;

        private ClassType m_ClassType;

        private MainGame()
        {
            m_Player = default;
            m_Field = default;
            m_ClassType = ClassType.None;
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
                Console.Clear();
                Console.WriteLine("    TextRPG    ");
                Console.WriteLine("===============");
                Console.WriteLine("1.게임시작 2.종료");

                bool bselect = int.TryParse(Console.ReadLine(), out int iselect);

                switch (iselect)
                {
                    case 1:
                        Console.Clear();
                        CreatePlayer();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("게임을 종료합니다.");
                        return;
                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력하세요");
                        Console.ReadLine();
                        continue;
                }

                break;
            }
        }

        public void CreatePlayer()
        {
            while(m_ClassType == ClassType.None)
            {
                Console.Clear();

                Console.WriteLine("캐릭터를 선택하세요");
                Console.WriteLine("1.전사 2.마법사 3.궁수 4.도적 5.해적");

                bool bselect = int.TryParse(Console.ReadLine(), out int iselect);

                switch (iselect)
                {
                    case 1:
                        m_ClassType = ClassType.Warrior;
                        m_Player = new Player("전사", 270, 150, 36);
                        break;
                    case 2:
                        m_ClassType = ClassType.Mage;
                        m_Player = new Player("마법사", 200, 150, 24);
                        break;
                    case 3:
                        m_ClassType = ClassType.Archer;
                        m_Player = new Player("궁수", 220, 150, 30);
                        break;
                    case 4:
                        m_ClassType = ClassType.Thief;
                        m_Player = new Player("도적", 180, 150, 28);
                        break;
                    case 5:
                        m_ClassType = ClassType.Pirate;
                        m_Player = new Player("해적", 250, 150, 32);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요.");
                        Console.ReadLine();
                        continue;
                }
            }
        }


        public void CheckPlayer()
        {
            if (m_Player != null)
            {
                Console.Clear();
                Console.WriteLine("캐릭터 생성 성공");
                Console.ReadLine();
                Console.Clear();

                Field();
            }
        }

        public void Field()
        {
            m_Field = new Field();

            m_Field.SelectField();
        }
    }
}
