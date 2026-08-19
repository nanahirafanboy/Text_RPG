using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._99.ETC;

namespace TextRPG._01.Character._00.Player
{
    public class Player : Character
    {
        public Player() : base() { }

        public Player(string name, int maxhp, int maxexp, int atk)
            : base(name, maxhp, maxexp, atk) { }

        public override void ShowInfo()
        {
            Console.WriteLine($"직업:{m_Info.sName}");
            Console.WriteLine($"레벨:{m_Info.iLevel}");
            Console.WriteLine($"체력:{m_Info.iCurHp}/{m_Info.iMaxHp}");
            Console.WriteLine($"공격력:{m_Info.iAtk}");
            Console.WriteLine($"경험치:{m_Info.iCurExp}/{m_Info.iMaxExp}");
        }

        public void TakeExp(int exp)
        {
            m_Info.iCurExp += exp;

            while (m_Info.iCurExp >= m_Info.iMaxExp)
            {
                m_Info.iCurExp -= m_Info.iMaxExp;
                m_Info.iLevel++;
                m_Info.iMaxHp = (int)(m_Info.iMaxHp * 1.3f);
                m_Info.iCurHp = m_Info.iMaxHp;
                m_Info.iAtk = (int)(m_Info.iAtk * 1.3f);
                m_Info.iMaxExp = (int)(m_Info.iMaxExp * 1.4f);
            }
        }

        public void Revive()
        {
            m_Info.iCurHp = m_Info.iMaxHp;
            m_Info.iCurExp -= 10;

            if (m_Info.iCurExp <= 0)
            {
                m_Info.iCurExp = 0;
            }
        }
    }
}
