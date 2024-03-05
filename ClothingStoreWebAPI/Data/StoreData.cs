
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
			modelBuilder.Entity<User>().HasData(users);

			var products = new Product[]
			{
				new Product
				{
					Name = "Chemise homme",Description = "Chemise élégante pour hommes",
					ProductId = 1,CategoryId = 1,Price = 49,ImageUrl = "vet"
				},
				new Product
				{
					Name = "Robe de soirée",Description = "Robe élégante pour les occasions spéciales",
					ProductId = 2,CategoryId = 2,Price = 129,ImageUrl = "rob"
				},
				new Product
				{
					Name = "Jean slim",Description = "Jean slim pour un look décontracté",
					ProductId = 3,CategoryId = 3,Price = 69,ImageUrl = "jean",
				},


			};
			modelBuilder.Entity<Product>().HasData(products);

			var categorys = new Category[]
			{
				new Category
				{
					CategoryId = 1, Name="Homme"
				},
				new Category
				{
					CategoryId= 2, Name="Femme"
				},
				new Category{ CategoryId= 3,Name = "Enfant"}
			};

			modelBuilder.Entity<Category>().HasData(categorys);

			var orders = new Order[]
			{
				new Order
				{
					OrderId = 1,
					UserId = 1,
					Status = "Terminé",
					//OrderProducts = new List<OrderProduct>()
					
				},

			new Order
				{
					OrderId = 2,
					UserId = 3,
					Status = "En cours",
					//OrderProducts = new List<OrderProduct>()
					
				},
			};
			modelBuilder.Entity<Order>().HasData(orders);

			var ordersProducts = new OrderProduct[]
			{
				new OrderProduct
						{
							OrderProductId=3,ProductId=3,Price=69, Quantity=1
						},
						new OrderProduct
						{
							OrderProductId=4,ProductId=2,Price=100,Quantity=2
						},
						new OrderProduct
						{
							OrderProductId=1,ProductId=1,Price=49, Quantity=5
						},
						new OrderProduct
						{
							OrderProductId=2,ProductId=2,Price=129,Quantity=2
						}
			};
			modelBuilder.Entity<OrderProduct>().HasData(ordersProducts);

		}
	}
}
