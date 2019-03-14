using System;
namespace LifeTest
{
    public abstract class Item
    {
        public string name;
        public int weight;
        public int value;
        public enum ItemType { food, tool, armor, misc};
        public ItemType itemType;

       
    }


}
