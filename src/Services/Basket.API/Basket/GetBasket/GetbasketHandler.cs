namespace Basket.API.Basket.GetBasket
{
    public record GetbasketQuery(string UserName) : IQuery<GetbasketResult>;
    public record GetbasketResult(ShoppingCart ShoppingCart);

    public class GetbasketHandler(IBasketRepository repository) : IQueryHandler<GetbasketQuery, GetbasketResult>
    {
        public async Task<GetbasketResult> Handle(GetbasketQuery query, CancellationToken cancellationToken)
        {
            var basket = await repository.GetBasket(query.UserName);

            return new GetbasketResult(basket);
        }
    }
}
