namespace Customer
{
    internal class Call
    {
        public char CallType { get; set; }
        public int Minutes { get; set; }
        public Customer Cust { get; set; }
        public Call(Customer cust, char tc, int minutes)
        {
            Cust = cust;
            CallType = tc;
            Minutes = minutes;
        }

        public void RecordCall()
        {
            if (Cust.Tarif == "longCall" && Minutes < 10)
            {
                if (CallType == 'Г')
                    Cust.Balance -= Minutes * 5;
                else
                        if (CallType == 'М')
                    Cust.Balance -= Minutes * 1;
            }
            if (Cust.Tarif == "longCall" && Minutes > 10)
            {
                if (CallType == 'Г')
                    Cust.Balance -= 50 + (Minutes - 10) * 2.5;
                else
                        if (CallType == 'М')
                    Cust.Balance -= Minutes * 1;
            }
            if (Cust.Tarif == "shortCall" && Minutes < 5)
            {
                if (CallType == 'Г')
                    Cust.Balance -= Minutes * 2.5;
                else
                        if (CallType == 'М')
                    Cust.Balance -= Minutes * 0.5;
            }
            if (Cust.Tarif == "shortCall" && Minutes > 5)
            {
                if (CallType == 'Г')
                    Cust.Balance -= 12.5 + (Minutes - 5) * 10;
                else
                        if (CallType == 'М')
                    Cust.Balance -= 2.5 + (Minutes - 5) * 2;
            }
            if (Cust.Tarif == "fair")
            {
                if (CallType == 'Г')
                    Cust.Balance -= Minutes * 5;
                else
                        if (CallType == 'М')
                    Cust.Balance -= Minutes * 1;
            }
        }
    }
}

