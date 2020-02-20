using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace generateItems
{

   

    abstract class Item
    {
        abstract public string name { get; set; }
        abstract public int id { get; set; }
        abstract public void Use();
    }

    abstract class ItemFactory
    {
        public abstract Item GetItem();
    }

    class Shield : Item
    {
        private string _name;
        private int _id;
        private double _defenseVal;

        public Shield(string name, int id, double defenseVal)
        {
            _id = id;
            _name = name;
            _defenseVal = defenseVal;
        }

        public override string name {
            get { return _name; }
            set { _name = value; }
        }
        public override int id {
            get { return _id; }
            set { _id = value; }
        }

        public override void Use()
        {
            Console.WriteLine("Typ: Shield\nName: " + name + "\nID: " + id);
        }
    }

    class ShieldFactory : ItemFactory
    {
        private int _id;
        private string _name;
        private float _defenseVal;


        public override Item GetItem()
        {
            return new Shield(_name, )
        }
    }

    public class ClientApplication
    {
        static void Main()
        {
            Shield shield = new Shield("moin", 10, 2.5);
            shield.Use();
            Console.ReadLine();
        }
    }
}
