using System;
namespace LifeTest
{

        public class Choice
        {
            public string prompt;
            public Action choiceAction;

            public Choice(string v, Action a)
            {
                prompt = v;
                choiceAction = a;
            }
        }

}
