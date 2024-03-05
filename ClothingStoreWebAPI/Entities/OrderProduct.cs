namespace ClothingStoreWebAPI.Entities
{
	public class OrderProduct
	{
		public int IdOrderProduct { get; set; }

		public int ProductId { get; set; }

		public int Price {  get; set; }

		public int Quantity { get; set; }
	}
}
