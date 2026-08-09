namespace Ordering.Application.Orders.EventHandlers
{
    public class OrderCreatedHandler(ILogger<OrderCreatedHandler> logger) : INotificationHandler<OrderCreatedEvent>
    {
        public Task Handle(OrderCreatedEvent notification, CancellationToken cancellationToken)
        {
            logger.LogInformation("OrderCreatedEvent handled for OrderId: {OrderId}", notification.order.Id);
            return Task.CompletedTask;
        }
    }
}
