using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStoreWebAPI.Entities
{
	public class OrderProduct
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderProductId { get; set; }

		public Product Product { get; set; } = new Product();
		public int Quantity { get; set; }
		public int Price { get; set; }
	}
}
