using System;
namespace LifeTest
{
    public abstract class Character
    {
        public int maxPointPool = 30;
        public Intelligence intel = new Intelligence();
        public Strength str = new Strength();
        public Endurance endur = new Endurance();
        public Charisma cha = new Charisma();
        public Luck luck = new Luck();
        Random rnd = new Random();
        public Inventory inv;
        

        public virtual void MakeValues() {
            intel.Initialize(rnd.Next(5, (maxPointPool / 4) + 4));
            maxPointPool -= intel.points;
            int strLowPointValue = (intel.points < 6) ? 6 : 4;
            int strHighPointValue = (intel.points > 8) ? (maxPointPool / 3) + 1 : (maxPointPool / 3) + 4;
            str.Initialize(rnd.Next(strLowPointValue, strHighPointValue));
            maxPointPool -= str.points;
            int endurLowPointValue = (str.points < 6) ? 7 : 5;
            int endurHighPointValue = (str.points > 8) ? (maxPointPool / 2) + 1 : (maxPointPool / 2) + 4;
            endur.Initialize(rnd.Next(endurLowPointValue, endurHighPointValue));
            maxPointPool -= endur.points;
            int chaLowPointValue = (endur.points < 6) ? 6 : 3;
            int chaHighPointValue = (endur.points > 8) ? (maxPointPool / 1) + 1 : (maxPointPool / 1) + 4;
            cha.Initialize(rnd.Next(chaLowPointValue, chaHighPointValue));
            maxPointPool -= cha.points;
            luck.Initialize(maxPointPool);
        }

        public Character()
        {
        }
    }
}
