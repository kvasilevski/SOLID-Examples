namespace Domain.SRP
{
    public interface ICommonValidators
    {
        bool ValidateEmail(string email);
    }

    public class CommonValidators : ICommonValidators
    {
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
