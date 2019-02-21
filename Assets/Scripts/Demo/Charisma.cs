using System;
namespace LifeTest
{
    public class Charisma : Skill
    {
        public int Clout;

        public override void Initialize(int pts)
        {
            base.Initialize(pts);
            if (pts - 6 > 0)
            {
                Clout = (pts - 6) * 2;  //some DnD stuff here
            }
            else
            {
                Clout = (pts - 6) / 2; //more DnD stuff
            }
        }

        public Charisma()
        {
        }
    }
}
