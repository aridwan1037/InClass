using System;
using System.Collections.Generic;
using System.IO;
using NLog;

namespace OnlineShop
{
    class Program
    {
        private static Logger logger = LogManager.GetCurrentClassLogger();

        static void Main(string[] args)
        {
            try
            {
                // Inisialisasi konfigurasi NLog
                var configPath = Path.Combine(Directory.GetCurrentDirectory(), "nlog.config");
                LogManager.Configuration = new NLog.Config.XmlLoggingConfiguration(configPath);

                // Tampilkan pesan log informasi saat aplikasi dijalankan
                logger.Info("Aplikasi jual beli online telah dimulai");

                // Buat daftar produk
                var products = new List<Product>
                {
                    new Product("001", "Sepatu", 100000),
                    new Product("002", "Tas", 150000),
                    new Product("003", "Baju", 80000),
                    new Product("004", "Celana", 90000),
                    new Product("005", "Topi", 50000)
                };

                // Tampilkan daftar produk
                Console.WriteLine("Daftar Produk:");
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.Code} - {product.Name} - Rp {product.Price}");
                }

                // Simulasikan pembelian produk oleh pengguna
                var user = new User("John");
                var selectedProduct = products[0];
                var transaction = new Transaction(user, selectedProduct, 1);
                Console.WriteLine($"Pembelian berhasil! Produk {selectedProduct.Name} telah dibeli oleh {user.Name}.");

                // Tampilkan riwayat transaksi
                var transactionHistory = new List<Transaction> { transaction };
                Console.WriteLine("Riwayat Transaksi:");
                foreach (var history in transactionHistory)
                {
                    Console.WriteLine($"{history.User.Name} membeli {history.Quantity} {history.Product.Name}(s) pada tanggal {history.Date}.");
                }

                // Tampilkan pesan log informasi saat aplikasi selesai dijalankan
                logger.Info("Aplikasi jual beli online telah selesai dijalankan");
            }
            catch (Exception ex)
            {
                // Tangani kesalahan dengan menampilkan pesan log kesalahan
                logger.Error(ex, "Terjadi kesalahan saat menjalankan aplikasi");
            }
        }
    }

    class Product
    {
        public string Code { get; }
        public string Name { get; }
        public decimal Price { get; }

        public Product(string code, string name, decimal price)
        {
            Code = code;
            Name = name;
            Price = price;
        }
    }

    class User
    {
        public string Name { get; }

        public User(string name)
        {
            Name = name;
        }
    }

    class Transaction
    {
        public User User { get; }
        public Product Product { get; }
        public int Quantity { get; }
        public DateTime Date { get; }

        public Transaction(User user, Product product, int quantity)
        {
            User = user;
            Product = product;
            Quantity = quantity;
            Date = DateTime.Now;
        }
    }
}