using System;
namespace LifeTest
{
    public class Endurance : Skill
    {

        public int Stamina;

        public override void Initialize(int pts) {
            base.Initialize( pts);
            if (pts - 6 > 0)
            {
                Stamina = (pts - 6) * 2;  //some DnD stuff here
            }
            else
            {
                Stamina = (pts - 6) / 2; //more DnD stuff
            }
        }
        public Endurance()
        {
        }
    }
}
