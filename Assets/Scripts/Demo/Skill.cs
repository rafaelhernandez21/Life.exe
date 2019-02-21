using System;
namespace LifeTest
{
    public abstract class Skill
    {
        int initialPoints;
        public int points;
        public bool randomize;
        Random rnd = new Random();

        public virtual void Initialize(int pts)
        {
            initialPoints = pts;
            points = pts;
        }

        public void Randomize()
        {
            if (randomize) {
                int newValue = rnd.Next(points / 2, points + (points / 2));
                points = newValue;
            }
        }

        public int GetPoints() {
            return points;
        }
        public void SetPoints(int pts) {
            points = pts;
        }
        public Skill()
        {
        }
    }
}
