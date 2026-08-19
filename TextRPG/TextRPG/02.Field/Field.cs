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
            m_FieldType = FieldType.None;

            Character player = MainGame.Instance().GetPlayer();

            player.ShowInfo();

            while(m_FieldType == FieldType.None)
            {
                Console.WriteLine("1.던전 2.상점 3.종료");

                int iselect = int.Parse(Console.ReadLine());

                switch(iselect)
                {
                    case 1:
                        m_FieldType = FieldType.Dungeon;
                        m_Dungeon.Update();
                        m_FieldType = FieldType.None;
                        break;
                }
            }
        }
    }
}
