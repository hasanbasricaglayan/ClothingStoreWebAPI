namespace ClothingStoreWebAPI.Entities
{
	public class Order
	{
		public int OrderId { get; set; }

		public int OrderProductId { get; set; }

		public int UserId { get; set; }
	}
}
