using System;
using System.Collections.Generic;
using System.Text;

namespace Pizzaaaaaaaa_storeeeeeeeeee
{
    class Customer
    {
        private int _id;
        private string _name;
        private double _telefonnr;
        private string _adresse;
        public Customer(int id, string name, double telefonnr, string adresse)
        {
            _id = id;
            _name = name;
            _telefonnr = telefonnr;
            _adresse = adresse;

        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Telefonnr
        {
            get { return _telefonnr; }
            set { _telefonnr = value; }
        }
        public override string ToString()
        {
            return _id + " " + _name + " " + " " + _telefonnr + " " + _adresse;
        }


    }

}




