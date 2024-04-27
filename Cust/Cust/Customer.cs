using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer
{
    class Customer
    {
        public string Name { get; set; }
        public double Balance { get; private set; }

        private string Tarif; 
        // 
        //    fair,
        //    shorCall,
        //    longCall
        //

        public Customer(string name, string tariff, double balance = 100)
        {
            Name = name;
            Balance = balance;
            Tarif = tariff;

        }

        public override string ToString()
        {
            return string.Format("Клиент: {0} имеет баланс: {1}, тариф {2}", Name, Balance, Tarif);
        }

        public void RecordPayment(double amountPaid)
        {
            if (amountPaid > 0)
                Balance += amountPaid;
        }

        

        public void RecordCall(char callType, int minutes, string tariff)
        {
            if (tariff == "longCall" && minutes < 10)
            {
                if (callType == 'Г')
                    Balance -= minutes * 5;
                else
                        if (callType == 'М')
                    Balance -= minutes * 1;
            }
            if (tariff == "longCall" && minutes > 10)
            {
                if (callType == 'Г')
                    Balance -= 50 + (minutes-10) * 2.5;
                else
                        if (callType == 'М')
                    Balance -= minutes * 1;
            }
            if (tariff == "shortCall" && minutes < 5)
            {
                if (callType == 'Г')
                    Balance -= minutes * 2.5;
                else
                        if (callType == 'М')
                    Balance -= minutes * 0.5;
            }
            if (tariff == "shortCall" && minutes > 5)
            {
                if (callType == 'Г')
                    Balance -= 12.5 + (minutes - 5) * 10;
                else
                        if (callType == 'М')
                    Balance -= 2.5 + (minutes - 5) * 2;
            }
            if (tariff == "fair")
            {
                if (callType == 'Г')
                    Balance -= minutes * 5;
                else
                        if (callType == 'М')
                    Balance -= minutes * 1;
            }

        }
    }
}
