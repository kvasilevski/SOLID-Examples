using System;

namespace Domain.SRP
{
    public class UserServiceGood
    {
        private readonly IEmailService _emailService;
        private readonly ICommonValidators _commonValidators;

        public UserServiceGood(IEmailService emailService, ICommonValidators commonValidators)
        {
            _emailService = emailService;
            _commonValidators = commonValidators;
        }

        public User Register(string email, string password)
        {
            if (_commonValidators.ValidateEmail(email))
            {
                throw new Exception("Email is not an email");
            }

            var user = new User()
            {
                Email = email,
                Password = password
            };
            //Store user somewhere

            _emailService.SendEmail(user);

            return user;
        }
    }
}
