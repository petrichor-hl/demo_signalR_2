namespace demo_signalR_2.Data
{
    public class DummyData
    {
        public class Product
        {
            public string? Id { get; set; }
            public string? Name { get; set; }
            public int Price { get; set; }
            public int Discount { get; set; }
        }

        public static readonly Product[] pcs = new Product[]
        {
            new Product { Id = "pc-1", Name = "PC TITAN Plus i4090", Price = 120000000, Discount = 2 },
            new Product { Id = "pc-2", Name = "PC ASUS EVANGELION 2", Price = 130000000, Discount = 5 },
            new Product { Id = "pc-3", Name = "PC VIPER Plus i4060", Price = 29990000, Discount = 3 },
            new Product { Id = "pc-4", Name = "PC PHANTOM i4060", Price = 32490000, Discount = 3 },
            new Product { Id = "pc-5", Name = "PC TITAN Plus a4090", Price = 115000000, Discount = 4 },
        };

        public class SaleProduct
        {
			public string? Id { get; set; }
			public string? Name { get; set; }
			public int Price { get; set; }
			public int Discount { get; set; }
            public int Sold { get; set; }
            public int Quantity { get; set; }
		}

        public static readonly SaleProduct[] macbooks = new SaleProduct[]
        {
            new SaleProduct { 
                Id = "air-m1-8cpu-7gpu-8-256-gold",
                Name = "MacBook Air M1 8CPU 7GPU 8GB 256GB - Gold",
                Price = 28490000,
                Discount = 34,
                Sold = 26,
				Quantity = 50
			},
			new SaleProduct {
				Id = "air-m1-8cpu-7gpu-8-256-grey",
				Name = "MacBook Air M1 8CPU 7GPU 8GB 256GB - Grey",
				Price = 28490000,
				Discount = 34,
				Sold = 19,
				Quantity = 50
			},

			new SaleProduct {
				Id = "air-m1-8cpu-7gpu-8-256-sliver",
				Name = "MacBook Air M1 8CPU 7GPU 8GB 256GB - Sliver",
				Price = 28490000,
				Discount = 34,
				Sold = 42,
				Quantity = 50
			},
			new SaleProduct {
				Id = "air-m2-8cpu-10gpu-8-512-midnight",
				Name = "Macbook Air M2 8CPU 10GPU 8GB 512GB - Midnight",
				Price = 28490000,
				Discount = 23,
				Sold = 15,
				Quantity = 20
			},
			new SaleProduct {
				Id = "air-m2-8cpu-10gpu-8-512-spacegray",
				Name = "Macbook Air M2 8CPU 10GPU 8GB 512GB - Space Gray",
				Price = 28490000,
				Discount = 23,
				Sold = 6,
				Quantity = 20
			},
			new SaleProduct {
				Id = "air-m2-8cpu-8gpu-16-256-midnight",
				Name = "Macbook Air M2 8CPU 8GPU 16GB 256GB - Midnight",
				Price = 39990000,
				Discount = 23,
				Sold = 2,
				Quantity = 20
			},
			new SaleProduct {
				Id = "air-m2-8cpu-8gpu-16-256-starlight",
				Name = "Macbook Air M2 8CPU 8GPU 16GB 256GB - Starlight",
				Price = 39990000,
				Discount = 23,
				Sold = 20,
				Quantity = 20
			},
			new SaleProduct {
				Id = "air-m2-8cpu-8gpu-8-256-spacegray",
				Name = "Macbook Air M2 8CPU 8GPU 8GB 256GB - Space Gray",
				Price = 28690000,
				Discount = 9,
				Sold = 13,
				Quantity = 20
			},
		};
    }
}
