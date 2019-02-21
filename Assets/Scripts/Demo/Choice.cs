using System;
namespace LifeTest
{
    //making this abstract means that every new choice we make will need to first be 
    //initialized by us, which wouldn't be too hard, considering the abstract does
    //most of the work, we put in the creativity, but it is something to keep in mind
    //this is where the list of choices would come in handy

    public abstract class Choice
    {  
        public string prompt;   
        //not sure if this part will be kept, may just make everything a value check
        public Action choiceAction;


        public void ValueCheck(int minimumPtsToPass, int ptValueChecking) 
        {
            if (ptValueChecking >= minimumPtsToPass)
            {
                Success();
            }
            else {
                Failed();
            }
        }
        public virtual void Success() { 
            //whatever happens if the player succeeds the skillCheck goes here
        }
        public virtual void Failed() { 
            //whatever happens if they fail goes here
        }

        public Choice(string v, Action a)
            {
                prompt = v;
                choiceAction = a;
                
            }
        }

}
