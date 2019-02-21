using System;
namespace LifeTest
{
    public class Intelligence : Skill
    { 
        public int PerceptionPts;


        public override void Initialize(int pts) {
            base.Initialize(pts);
            if (pts - 6 > 0)
            {
                PerceptionPts = (pts - 6) * 2;  //some DnD stuff here
            }
            else {
                PerceptionPts = (pts - 6) / 2; //more DnD stuff
            }

        }
        public Intelligence()
        {
        }
    }
}
