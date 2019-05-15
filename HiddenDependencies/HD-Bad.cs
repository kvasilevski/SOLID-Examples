namespace Domain.HiddenDependencies.Bad
{
    public class OrderProcessor : IOrderProcessor
    {
        public void Process(Order order)
        {
            var validator = Locator.Resolve<IOrderValidator>();
            if (validator.Validate(order))
            {
                var shipper = Locator.Resolve<IOrderShipper>();
                shipper.Ship(order);
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
