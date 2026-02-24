namespace Ordering.Domain.ValueObjects
{
    public record OrderId
    {
        public Guid Value { get; }

        private OrderId(Guid value)
        {
            Value = value;
        }

        public static OrderId Of(Guid value)
        {
            /// value type (struct) can not null?
            //ArgumentNullException.ThrowIfNull(value);
            if (value == Guid.Empty)
            {
                throw new DomainException("OrderId cannot be empty.");
            }
            return new OrderId(value);
        }
    }
}
