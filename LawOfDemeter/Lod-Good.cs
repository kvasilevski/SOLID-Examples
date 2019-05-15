namespace Domain.LawOfDemeter.Good
{
    public class Wallet
    {
        public Wallet(float initialAmount)
        {
            Value = initialAmount;
        }

        public float Value { get; private set; }

        public void AddMoney(float amount)
        {
            Value += amount;
        }

        public void SubMoney(float amount)
        {
            Value -= amount;
        }
    }

    public class Customer
    {
        public Customer()
        {
            FirstName = "John";
            LastName = "Doe";
            _wallet = new Wallet(20.0f); // amount set to 20 for example
        }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        private Wallet _wallet;

        public float PayAmount(float amountToPay)
        {
            if (_wallet.Value >= amountToPay)
            {
                _wallet.SubMoney(amountToPay);
                return amountToPay;
            }
            return 0;
        }
    }

    public class Paperboy
    {
        public void SellPaper(Customer customer)
        {
            var payment = 2.0f;
            var amountPaid = customer.PayAmount(payment);
            if (amountPaid != payment)
            {
                // come back later
            }
        }
    }
}
