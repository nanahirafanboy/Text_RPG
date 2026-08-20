using System;
using System.Collections.Generic;
using System.Text;
using TextRPG._00.MainGame;
using TextRPG._01.Character;
using TextRPG._01.Character._00.Player;
using TextRPG._01.Character._01.Enemy;
using TextRPG._99.ETC;


namespace TextRPG._02.Field._00.Dungeon
{
    public class Dungeon
    {
        private Character m_Player;
        private Character m_Enemy;
        private DungeonType m_DungeonType = DungeonType.None;

        public Dungeon()
        {
            m_Enemy = default;
            m_Player = MainGame.Instance().GetPlayer();
        }

        public void Update()
        {
            while(DungeonSelect())
            {
                Battle();
            }
        }

        public void DungeonLevel()
        { 
            Console.WriteLine("========================");
            Console.WriteLine("          던전         ");
            Console.WriteLine("========================");
            Console.WriteLine(" 1.쉬움 2.보통 3.어려움 4.마을로");
        }

        public bool DungeonSelect()
        {
            while(m_DungeonType == DungeonType.None)
            {
                Console.Clear();

                DungeonLevel();

                bool bselect = int.TryParse(Console.ReadLine(), out int iselect);

                switch (iselect)
                {
                    case 1:
                        m_DungeonType = DungeonType.SlimeDungeon;
                        m_Enemy = new Enemy("슬라임", 170, 13);
                        return true;
                    case 2:
                        m_DungeonType = DungeonType.GoblinDungeon;
                        m_Enemy = new Enemy("고블린", 230, 22);
                        return true;
                    case 3:
                        m_DungeonType = DungeonType.SkeletonDungeon;
                        m_Enemy = new Enemy("스켈레톤", 280, 30);
                        return true;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("마을로 돌아갑니다.");
                        Console.ReadLine();
                        return false;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 선택 하세요");
                        continue;
                }
            }

            return false;
        }

        public void Battle()
        {
            while(m_Player.IsLive() && m_Enemy.IsLive())
            {
                Console.Clear();

                m_Player.ShowInfo();
                Console.WriteLine();
                m_Enemy.ShowInfo();
                Console.WriteLine("=========================");
                Console.WriteLine("1.전투 2.도망");

                bool bselect = int.TryParse(Console.ReadLine(), out int iselect);

                switch (iselect)
                {
                    case 1:
                        m_Enemy.TakeDamage(m_Player.GetInfo().iAtk);
                        m_Player.TakeDamage(m_Enemy.GetInfo().iAtk);
                        break;
                    case 2:
                        m_DungeonType = DungeonType.None;
                        Console.Clear();
                        Console.WriteLine("던전입구로 돌아갑니다");
                        Console.ReadLine();
                        DungeonSelect();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("잘못된 입력입니다. 다시 선택 하세요");
                        Console.ReadLine();
                        continue;
                }

                BattleResult();
            }
        }

        public void BattleResult()
        {
            Console.Clear();

            if(!m_Player.IsLive())
            {
                Console.WriteLine("사망하였습니다.");
                Console.ReadLine();
                Player m_player = (Player)m_Player;
                m_player.Revive();
                m_DungeonType = DungeonType.None;
            }
            else if(!m_Enemy.IsLive())
            {
                Console.WriteLine("사냥성공");
                Console.ReadLine();
                Player m_player = (Player)m_Player;
                m_player.TakeExp(15);
                m_DungeonType = DungeonType.None;
            }
        }
    }
}
