using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStoreWebAPI.Entities
{
	public class Order
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderId { get; set; }

		public List<OrderProduct> OrderProducts { get; set; } = [];
		public string Status { get; set; } = string.Empty;

		[ForeignKey("UserId")]
		public int UserId { get; set; }
	}
}
