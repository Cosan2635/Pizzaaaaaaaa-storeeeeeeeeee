using System;
using System.Collections.Generic;
using System.Text;
namespace Pizzaaaaaaaa_storeeeeeeeeee
{
    class Pizza
    {
        private int _id;
        private string _name;
        private double _price;

        public Pizza(int ID, string name, double price)
        {
            _id = ID;
            _name = name;
            _price = price;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }





        public override string ToString()
        {
            return _id + " " + _name + " " + " " + _price + " ";
        }
    }

}

