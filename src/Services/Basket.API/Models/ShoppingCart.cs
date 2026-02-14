namespace Basket.API.Models
{
    /// <summary>
    /// Represents a shopping cart containing items selected by a user for purchase.
    /// </summary>
    /// <remarks>A ShoppingCart instance tracks the items a user intends to buy and provides the total price
    /// based on the current contents. The cart is associated with a specific user and can be used to manage the user's
    /// selections before checkout.</remarks>
    public class ShoppingCart
    {
       
        public string UserName { get; set; } = default!;
        public List<ShoppingCartItem> Items { get; set; } = new();
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Price * item.Quantity;
                }
                return totalPrice;
            }
        }

        /// <summary>
        /// Initializes a new instance of the ShoppingCart class for the specified user.
        /// </summary>
        /// <param name="userName">The name of the user associated with the shopping cart. Cannot be null or empty.</param>
        public ShoppingCart(string userName)
        {
            this.UserName = userName;
        }

        /// <summary>
        /// Initializes a new instance of the ShoppingCart class.
        /// </summary>
        public ShoppingCart()
        {

        }
    }
}
