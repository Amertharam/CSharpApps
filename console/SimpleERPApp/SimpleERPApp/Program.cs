using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using Microsoft.EntityFrameworkCore;

namespace SimpleERPApp
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ReorderLevel { get; set; } = 10;
        public List<SalesOrderItem> SalesOrderItems { get; set; } = new();
        public List<PurchaseOrderItem> PurchaseOrderItems { get; set; } = new();
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public List<SalesOrder> SalesOrders { get; set; } = new();
    }

    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public List<PurchaseOrder> PurchaseOrders { get; set; } = new();
    }

    public class SalesOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<SalesOrderItem> Items { get; set; } = new();
        public decimal Total => Items.Sum(i => i.Total);
    }

    public class SalesOrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Total => Quantity * Product.Price;
    }

    public class PurchaseOrder
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public List<PurchaseOrderItem> Items { get; set; } = new();
    }

    public class PurchaseOrderItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }

    public class ERPContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=erp.db");
    }

    class Program
    {
        static ERPContext db = new ERPContext();

        static void Main(string[] args)
        {
            db.Database.EnsureCreated();
            SeedData();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Fashion ERP System");
                Console.WriteLine("1. Inventory Management");
                Console.WriteLine("2. Sales Management");
                Console.WriteLine("3. Purchase Management");
                Console.WriteLine("4. Reports");
                Console.WriteLine("5. Exit");

                switch (GetChoice(5))
                {
                    case 1: InventoryMenu(); break;
                    case 2: SalesMenu(); break;
                    case 3: PurchaseMenu(); break;
                    case 4: ReportsMenu(); break;
                    case 5: return;
                }
            }
        }

        static void InventoryMenu()
        {
            // CRUD operations for products
        }

        static void SalesMenu()
        {
            // Sales order management
        }

        static void PurchaseMenu()
        {
            // Purchase order management
        }

        static void ReportsMenu()
        {
            Console.Clear();
            Console.WriteLine("Reports");
            Console.WriteLine("1. Low Stock Report");
            Console.WriteLine("2. Sales Report");
            Console.WriteLine("3. Back");

            switch (GetChoice(3))
            {
                case 1:
                    var lowStock = db.Products.Where(p => p.Quantity < p.ReorderLevel).ToList();
                    Console.WriteLine("Low Stock Items:");
                    lowStock.ForEach(p => Console.WriteLine($"{p.Name} ({p.Size}/{p.Color}): {p.Quantity}"));
                    break;
                case 2:
                    var sales = db.SalesOrders.Include(so => so.Customer).Include(so => so.Items).ThenInclude(i => i.Product).ToList();
                    sales.ForEach(so => Console.WriteLine($"{so.OrderDate:d} - {so.Customer.Name}: {so.Total:C}"));
                    break;
            }
            Console.ReadKey();
        }

        static int GetChoice(int max)
        {
            int choice;
            while (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out choice) || choice < 1 || choice > max)
                Console.Write($"\nInvalid input. Enter 1-{max}: ");
            return choice;
        }

        static void SeedData()
        {
            if (!db.Products.Any())
            {
                db.Products.Add(new Product { Name = "Designer Jeans", Size = "32", Color = "Blue", Price = 199.99m, Quantity = 15 });
                db.Customers.Add(new Customer { Name = "John Doe", Email = "john@example.com", Phone = "555-1234" });
                db.Suppliers.Add(new Supplier { Name = "Fabric World", Contact = "Jane Smith" });
                db.SaveChanges();
            }
        }
    }

}
