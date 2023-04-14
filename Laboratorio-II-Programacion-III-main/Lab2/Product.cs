using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Product
    {
        public string Name { get; set; }
        public string Provider { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime EntryDate { get; set; }
        public string Details { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }
        public Category Category { get; set; }

        public Product(string name, string provider, DateTime expirationDate, DateTime entryDate, string details, double price, int units, Category category)
        {
            Name = name;
            Provider = provider;
            ExpirationDate = expirationDate;
            EntryDate = entryDate;
            Details = details;
            Price = price;
            Units = units;
            Category = category;
        }
    }
}
