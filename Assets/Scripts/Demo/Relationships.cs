using System;
using System.Collections.Generic;
using System.Linq;
namespace LifeTest{

  public class Relationships{
    public List<Relationship> peeps = List<Relationship>();
    
    public void AddPerson(Character char, int liking){
      //if(!peeps.Contains(Char)){
        //peeps.Add(char);
      //}
    }
    
    public void ChangeReputation(){
    
    }
   
    
  }
  
  public class Relationship{
    Character person;
    int clout;
    public Relationship(Character p, int c){
      person = p;
      clout = c;
    }
  }

}
