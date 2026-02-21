namespace Catalog.API.Products.UpdateProduct
{
    public class UpdateProductEndpoint : ICarterModule
    {
        public record UpdateProductRequest(Guid Id, string Name, List<string> Category, string Description, string ImageFile, decimal Price);
        public record UpdateProductResponse(bool IsSuccess);

        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/products", async (UpdateProductRequest command, ISender sender) =>
            {
                await sender.Send(command);
                return Results.NoContent();
            })
            .WithName("UpdateProduct")
            .Produces(StatusCodes.Status204NoContent)
            .ProducesProblem(StatusCodes.Status400BadRequest)
            .ProducesProblem(StatusCodes.Status404NotFound)
            .WithSummary("Update Product")
            .WithDescription("Update Product");
        }
    }
}
