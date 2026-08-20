using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._00.MainGame;
using TextRPG._01.Character;
using TextRPG._02.Field._00.Dungeon;
using TextRPG._02.Field._01.Store;
using TextRPG._99.ETC;

namespace TextRPG._02.Field
{
    public class Field
    {
        Dungeon m_Dungeon;
        Store m_Store;
        FieldType m_FieldType;

        public Field()
        {
            m_Dungeon = new Dungeon();
            m_Store = new Store();
        }


        public void SelectField()
        {
            Character player = MainGame.Instance().GetPlayer();

            bool bisrunning = true;
            
            while(m_FieldType == FieldType.None && bisrunning)
            {
                Console.Clear();

                m_FieldType = FieldType.None;

                player.ShowInfo();
                Console.WriteLine();
                Console.WriteLine("1.던전 2.상점 3.종료");

                bool bselect = int.TryParse(Console.ReadLine(), out int iselect);

                switch(iselect)
                {
                    case 1:
                        m_FieldType = FieldType.Dungeon;
                        m_Dungeon.Update();
                        m_FieldType = FieldType.None;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("게임을 종료합니다");
                        bisrunning = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("다시 입력하세요");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
