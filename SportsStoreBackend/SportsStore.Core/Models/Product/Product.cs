using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;

namespace SportsStore.Core.Models.Product
{
    public class Product
    {
        public const int MAX_LENGTH = 100;
        public Guid Id { get; private set; }

        public string Name { get; private set; } = string.Empty;

        public string Description { get; private set; } = string.Empty;

        public Money Price { get; private set; }

        private Product(Guid id, string name, string description, Money price)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
        }



        public (Product, string) Create(Guid id, string name, string description, Money price)
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(name) || name.Length <= MAX_LENGTH || !name.Any(x => char.IsDigit(x)))
            {
                error = "Имя строки имело неверный формат:";
            }

            return (new Product(id, name, description, price), error);

        }

    }
}
