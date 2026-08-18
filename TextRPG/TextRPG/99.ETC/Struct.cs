namespace TextRPG._99.ETC
{
    public struct Info
    {
        public string sName;
        public int iLevel;
        public int iMaxHp;
        public int iCurHp;
        public int iAtk;
        public int iMaxExp;
        public int iCurExp;

        public Info(string name, int maxhp, int maxexp, int atk)
        {
            sName = name;
            iLevel = 1;
            iMaxHp = maxhp;
            iCurHp = iMaxHp;
            iAtk = atk;
            iMaxExp = maxexp;
            iCurExp = 0;
        }
    }
}