namespace Basket.API.Basket.GetBasket
{
    public record GetbasketQuery(string UserName) : IQuery<GetbasketResult>;
    public record GetbasketResult(ShoppingCart ShoppingCart);

    public class GetbasketHandler : IQueryHandler<GetbasketQuery, GetbasketResult>
    {
        public async Task<GetbasketResult> Handle(GetbasketQuery request, CancellationToken cancellationToken)
        {
            return new GetbasketResult(new ShoppingCart("Dung Ha"));
        }
    }
}
