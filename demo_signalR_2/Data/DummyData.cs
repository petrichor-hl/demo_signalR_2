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

        private static readonly Product[] products1 = new Product[]
                {
            new Product { Id = "pc-1", Name = "PC TITAN Plus i4090", Price = 120000000, Discount = 2 },
            new Product { Id = "pc-2", Name = "PC ASUS EVANGELION 2", Price = 130000000, Discount = 5 },
            new Product { Id = "pc-3", Name = "PC VIPER Plus i4060", Price = 29990000, Discount = 3 },
            new Product { Id = "pc-4", Name = "PC PHANTOM i4060", Price = 32490000, Discount = 3 },
            new Product { Id = "pc-5", Name = "PC TITAN Plus a4090", Price = 115000000, Discount = 4 },
                };
        public static Product[] products = products1;
    }
}
