using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Learning
{
    internal class Custormer
    {
        //public int Custid; // don't make fields as public
        int _Custid; // defining field by usig underscore symbol
        bool _Status;
        string _Cname,_State;
        double _Balance;
        Cities _City;
        
        public Custormer(int Custid,
                         bool Status,
                         string Cname,
                         double Balance,
                         Cities City,
                         string State
                         // string Country
            )
        {
            _Custid = Custid;
            _Status = Status;
            _Cname = Cname;
            _Balance = Balance;
            _City = City;
            _State = State;
           // this.Country = Country;

        }
        public int Custid //defining property
        {
            get { return _Custid; }
            //set { _Custid = value; }
        }
        public bool Status // defining property
        {
            get { return _Status; }
            set { _Status = value; }
        }
        public string Cname
        {
            get { return _Cname; }
            set
            {
                if (_Status == true)
                    _Cname = value;
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if (_Status == true)
                {
                    if (value > 500)
                    { _Balance = value; }
                }
            }
        }
       /* public string City
        {
            get { return _City; }
            set
            {
                if (_Status == true)
                {
                    if (value == "Kolkata" || value == "Delhi" || value == "Bangalore" || value == "Chennai" || value == "Hyderabad")
                    { 
                        _City = value; 
                    }
                }
            }
        }*/
       public Cities City { 
            get { return _City; } 
            set
            {
                if (_Status==true)
                    _City = value;
            }
        }
        public string State
        {
            get { return _State; }
            set 
            { 
                if( _Status == true)
                    _State = value;
            }
        }
        /*public string Country // Auto implemented or Automatic Properties
        {
            get;
            set;
        }*/
        public string Country // Auto implemented initializer
        {
            get;
        } = "India";
        
    }
}
