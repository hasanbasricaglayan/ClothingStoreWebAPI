
using ClothingStoreWebAPI.Entities;
using Microsoft.EntityFrameworkCore;
namespace ClothingStoreWebAPI.Data
{
	public class StoreData : DbContext
	{
		public DbSet<User> Users { get; set; } = null!;
		public DbSet<Product> Products { get; set; } = null!;

		public DbSet<Order> Orders { get; set; } = null!;

		public DbSet<Category> Categories { get; set; } = null!;

		public DbSet<Image> Images { get; set; } = null!;

		public DbSet<OrderProduct> OrderProducts { get; set; } = null!;


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ClothingStoreDb");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			var users = new User[]
			{
				new User { UserId=1,FirstName = "Charles" , LastName = "Victor",
					DateOfBirth = new DateOnly(2000,1,1), Email="charles.Victors@email.com"
					,Password = "charlesV"
				},
				new User { UserId = 2, FirstName = "Charles", LastName="Duhigg",
				DateOfBirth=new DateOnly(1998,5,23),Email="charles.Duhigg@email.com"
					,Password = "charlesD"
				},
				new User { UserId = 3, FirstName = "Victor", LastName="Hugo",
				DateOfBirth=new DateOnly(1998,5,23),Email="Victor.Hugo@email.com"
					,Password = "VictorH"
				},
			};

			var products = new Product[]
			{
				new Product
				{
					ProductName = "Chemise homme",ProductDescription = "Chemise élégante pour hommes",
					ProductId = 1,ProductCategoryId = 1,Price = 49,UrlImage = "vet"
				},
				new Product
				{
					ProductName = "Robe de soirée",ProductDescription = "Robe élégante pour les occasions spéciales",
					ProductId = 2,ProductCategoryId = 2,Price = 129,UrlImage = "rob"
				},
				new Product
				{
					ProductName = "Jean slim",ProductDescription = "Jean slim pour un look décontracté",
					ProductId = 3,ProductCategoryId = 3,Price = 69,UrlImage = "jean",
				},


			};

			var categorys = new Category[]
			{
				new Category
				{
					CategoryId = 1, CategoryName="Homme"
				},
				new Category
				{
					CategoryId= 2, CategoryName="Femme"
				},
				new Category{ CategoryId= 3,CategoryName = "Enfant"}
			};
			var orders = new Order[]
			{
				new Order
				{
					OrderId = 1,
					UserId = 1,
					OrderProductId = new List<OrderProduct>()
					{
						new OrderProduct
						{
							IdOrderProduct=1,ProductId=1,Price=49, Quantity=5
						},
						new OrderProduct
						{
							IdOrderProduct=2,ProductId=2,Price=129,Quantity=2
						}
					}
				},
				new Order
				{
					OrderId = 2,
					UserId = 3,
					OrderProductId = new List<OrderProduct>()
					{
						new OrderProduct
						{
							IdOrderProduct=3,ProductId=3,Price=69, Quantity=1
						},
						new OrderProduct
						{
							IdOrderProduct=4,ProductId=2,Price=100,Quantity=2
						}
					}
				},
			};
			
		}
	}
}
