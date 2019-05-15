namespace Domain.HiddenDependencies.Good
{
    public class OrderProcessor : IOrderProcessor
    {
        private readonly IOrderValidator _validator;
        private readonly IOrderShipper _shipper;

        public OrderProcessor(IOrderValidator validator, IOrderShipper shipper)
        {
            _validator = validator;
            _shipper = shipper;
        }

        public void Process(Order order)
        {
            if (_validator.Validate(order))
            {
                _shipper.Ship(order);
            }
        }
    }

    public interface IOrderProcessor
    {
        void Process(Order order);
    }

    public class Order
    {
        //order properties
    }

    public class Locator
    {
        public static dynamic Resolve<T>()
        {
            if (typeof(IOrderValidator).IsAssignableFrom(typeof(T)))
                return new OrderValidator();

            if (typeof(IOrderShipper).IsAssignableFrom(typeof(T)))
                return new OrderShipper();

            return null;
        }
    }

    public interface IOrderValidator
    {
        bool Validate(Order order);
    }

    public class OrderValidator : IOrderValidator
    {
        bool IOrderValidator.Validate(Order order)
        {
            //some validation
            return true;
        }
    }

    public interface IOrderShipper
    {
        bool Ship(Order order);
    }

    public class OrderShipper : IOrderShipper
    {
        public bool Ship(Order order)
        {
            //some shipping
            return true;
        }
    }
}
