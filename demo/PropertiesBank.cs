using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class PropertiesBank
    {
        private string _CustomerName;
        private int _CustomerId;
        private bool _CustomerStatus;
        private double _Balance;
        public PropertiesBank(string c, int d, bool e, double f)
        {
            _CustomerId = d;
            _CustomerName = c;
            _CustomerStatus = e;
            _Balance = f;
        }
        public string CustomerName
        {

            get
            {
                return _CustomerName;
            }
            set              // if the account is active then only Customer Name can change
            {
                if(CustomerStatus == true)
                    _CustomerName = value;
            }

        }
        public int CustomerId
        {

            get                           //only can get the CustomerId but cannot set the customer Id
            {
                return _CustomerId;
            }
        }
        public bool CustomerStatus
        {
            get
            {
                return _CustomerStatus;
            }
            set 
            {                                               
                _CustomerStatus = value;
            }
        }
        public double Balance
        {
            get { return _Balance; }
            set
            {
                if(CustomerStatus == true)    // if the account is active then only make transcation
                    if(value>0)               //value greater than the balance value this peints the previous value
                        _Balance = value;
            }
        }


    }
    public class PropertiesBankDetails
    {
        static void Main()
        {
            PropertiesBank p = new PropertiesBank("Raj",125,false,15000);
            if (p.CustomerStatus == true)
                Console.WriteLine($"Customer status is:Active");
            else
                Console.WriteLine($"Customer status is:Inactive");
            Console.WriteLine("Customer Name is:" +p.CustomerName);
            Console.WriteLine("Customer Balance is:" + p.Balance);
            Console.WriteLine(p.CustomerId);
            //p.CustomerId = 201;   //restricts the CustomerId to change

            p.Balance -= 14000;       
            Console.WriteLine("Customer Balance is:" + p.Balance);

            p.CustomerName += "Kumar";
            Console.WriteLine("Customer Name is:" + p.CustomerName);
            


        }
    }
}
