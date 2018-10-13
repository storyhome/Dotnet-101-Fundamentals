using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Encapulation2_1
{
    class CustomerQueueRepository
    {
        private Queue<Customer> _customerQueue;


        public CustomerQueueRepository()
        {
            _customerQueue = new Queue<Customer>();
        }
        public void AddCustomerToQueue(Customer customer)
        {
            _customerQueue.Enqueue((customer));

        }


        //public Customer PeekCustomerInQueue()
        //{
        //    if (_customerQueue.Contains() == 0)
                

        //   var customer = _customerQueue.Peek();
        //    return customer;
        //}

        public Customer RemoveCustomerFromQueue()
        {

            var customer = _customerQueue.Dequeue();
            return customer;
        }

    } 

}
