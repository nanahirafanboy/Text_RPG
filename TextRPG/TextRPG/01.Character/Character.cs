using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._99.ETC;

namespace TextRPG._01.Character
{
    public class Character
    {
        protected Info m_Info;

        public Info Info
        {
            get => m_Info;
            set => m_Info = value;
        }

        public Character()
        {
            m_Info = default;
        }

        public Character(string name, int maxhp, int maxexp, int atk)
        {
            Init(name, maxhp, maxexp, atk);
        }

        public Info GetInfo() => m_Info;

        public void TakeDamage(int damage)
        {
            m_Info.iCurHp -= damage;
        }

        public bool IsLive() => m_Info.iCurHp > 0;

        protected void Init(string name, int maxhp, int maxexp, int atk)
        {
            m_Info = new Info(name, maxhp, maxexp, atk);
        }

        public virtual void ShowInfo()
        {

        }
    }
}