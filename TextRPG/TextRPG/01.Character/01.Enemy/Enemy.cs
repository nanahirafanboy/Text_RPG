using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._99.ETC;

namespace TextRPG._01.Character._01.Enemy
{
    public class Enemy : Character
    {
        public Enemy() : base() { }

        public Enemy(string name, int maxhp, int atk)
            : base(name, maxhp, 0, atk) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"이름:{m_Info.sName}");
            Console.WriteLine($"체력:{m_Info.iCurHp}/{m_Info.iMaxHp}");
            Console.WriteLine($"공격력:{m_Info.iAtk}");
        }
    }
}
