using System;
using System.Collections.Generic;
using System.Linq;
namespace LifeTest{

  public class Relationships{
    public List<Relationship> peeps = List<Relationship>();
    
    public void AddPerson(Character char, int initialTrust, int initialFear){
      //if(!peeps.Contains(Char)){
        //peeps.Add(char);
      //}
      
      Reputation rep = new Reputation(initialTrust, initialFear);
      Relationship rel = new Relationship(char, rep, (initialTrust+initialFear)/2);
      peeps.Add(rel);
    }   
  }
  
  public class Relationship{
    Character person;
    Reputation rep;
    int clout;
    public Relationship(Character p, Reputation r, int c){
      person = p;
      rep = r;
      clout = c;
    }
  }

}
