namespace ClothingStoreWebAPI.Entities
{
	public class Product
	{
		public string ?ProductName { get; set; }
		public string ?ProductDescription { get; set; }

		public int ProductId { get; set; }

		public int ProductCategoryId { get; set;}

		public double Price {  get; set; }

		//public int ImageID {  get; set; }

		public string ?UrlImage {  get; set; }
	}
}
