using System;
using System.Collections;
using System.Collections.Generic;

namespace Life {
  public class Reputation {
    public int trust;
    public int fear;
    public bool nullRelationship = false;
    
    public void ChangeTrust(int amt){
      trust += amt;
    }
    public void ChangeFear(int amt){
      fear += amt;
    }
    
    public void Update(){
      if ((trust < 10 || trust == 0) & (fear < 10 || fear == 0)){
        //somehow make relationship null
        nullRelationship = true;
      }
    }
  }
} 
