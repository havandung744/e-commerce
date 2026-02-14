namespace Basket.API.Basket.StoreBasket
{
    public record StoreBasketCommand(ShoppingCart ShoppingCart) : ICommand<StoreBasketResult>;
    public record StoreBasketResult(bool IsSuccess);

    public class StoreBasketCommandValidator : AbstractValidator<StoreBasketCommand>
    {
        public StoreBasketCommandValidator()
        {
            RuleFor(x => x.ShoppingCart).NotNull().WithMessage("Shopping cart is required");
            RuleFor(x => x.ShoppingCart.UserName).NotEmpty().WithMessage("User name is required");
            RuleFor(x => x.ShoppingCart.Items).NotEmpty().WithMessage("Shopping cart must contain at least one item");
        }
    }

    public class StoreBasketHandler : ICommandhandler<StoreBasketCommand, StoreBasketResult>
    {
        public async Task<StoreBasketResult> Handle(StoreBasketCommand request, CancellationToken cancellationToken)
        {
           return new StoreBasketResult(true);
        }
    }
}
