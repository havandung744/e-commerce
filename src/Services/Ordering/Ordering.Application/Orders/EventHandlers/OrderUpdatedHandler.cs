namespace Ordering.Application.Orders.EventHandlers
{
    public class OrderUpdatedHandler(ILogger<OrderUpdatedHandler> logger) : INotificationHandler<OrderUpdatedEvent>
    {
        public Task Handle(OrderUpdatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("Order with ID {OrderId} has been updated.", notification.GetType().Name);
            return
        }
    }
}
