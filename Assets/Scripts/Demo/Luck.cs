using System;
namespace LifeTest
{
    public class Luck : Skill
    {
        public override void Initialize(int pts)
        {
            base.Initialize(pts);
            randomize = true;
        }
        public Luck()
        {
        }
    }
}
