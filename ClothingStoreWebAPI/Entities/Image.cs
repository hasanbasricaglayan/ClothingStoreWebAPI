using System.ComponentModel.DataAnnotations;

namespace ClothingStoreWebAPI.Entities
{
	public class Image
	{
		[Key]
		public int ImageId { get; set; }

		public List<string> ImageUrls { get; set; } = [];
	}
}
