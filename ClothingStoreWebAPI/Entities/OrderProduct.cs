using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClothingStoreWebAPI.Entities
{
	public class OrderProduct
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int OrderProductId { get; set; }

		[ForeignKey("ProductId")]
		public int ProductId { get; set; }

		public Product Product { get; set; }
        public double Price { get; set; }

        public int Quantity { get; set; }
    }
}
