using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class MyDictionary<Id, Customer>
    {

        Id[] _id;
        Customer[] _customer;

        public MyDictionary()
        {
            _id = new Id[0];
            _customer = new Customer[0];
        }

        public void Add(Id id,Customer customer) 
        {
            Id[] tempArrayId = _id;
            Customer[] tempArrayCustomer = _customer;

            _id = new Id[_id.Length +1 ];
            _customer = new Customer[_customer.Length +1];

            for (int i = 0; i < tempArrayId.Length; i++)
            {
                _id[i] = tempArrayId[i];
                _customer[i] = tempArrayCustomer[i];
            }

            _id[_id.Length - 1] = id;
            _customer[_customer.Length - 1] = customer;
        }

        public int Length 
        {
            get 
            {
                return _id.Length;
            } 
        }
        public  Id[] _Id 
        {
            get 
            {
                return _id;  
            } 
        }
        public  Customer[] _Customer 
        {
            get 
            {
                return _customer;  
            } 
        }



    }
}


