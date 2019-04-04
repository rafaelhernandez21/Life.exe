using System;
using System.Collections;
using System.Collections.Generic;

namespace LifeTest{
//essentially just make a trade interface where items from each inventory can be selected and traded
//bad trades lower reputations
//giving a person something poisonous or dangerous can increase fear, adds to clout 
//good trades increase trust
  public class Trade {
    public void VerifyTrade(Item i1, Item i2){
      if(i1.owner == i2.owner || i1 == i2){
        
        Print("Invalid Trade");
      }else{
        InitiateTrade(i1.owner, i1, i2.owner, i2);
      }
    }
    public void InitiateTrade(Character owner1, Item item1, Character owner2, Item item2){
      if(item1.value == item2.value){
        //decent trade
      }else if (item1.value < item2.value){
      //good trade 
      }else if (item1.value > item2.value){
      //bad trade
      }
    
    }
  }

}
