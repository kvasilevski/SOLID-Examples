namespace Domain.LawOfDemeter
{
    public class Wallet
    {
        public float Value { get; set; }

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
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Wallet Wallet { get; set; }
    }

    public class Paperboy
    {
        public void SellPaper(Customer customer)
        {
            var payment = 2.0f;
            if (customer.Wallet.Value >= payment)
            {
                customer.Wallet.SubMoney(payment);
            }
            else
            {
                // come back later
            }
        }
    }
}
