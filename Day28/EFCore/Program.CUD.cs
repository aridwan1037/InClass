using EFCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProgramEFCore
{
    partial class Program
    {

        static void AddCategory()
        {
            using (Northwind db = new())
            {
                SectionTitle("Adding a Category");
                bool available;
                string name;
                string description;
                do
                {
                    Printer("Enter the category name: ");
                    name = GetInput();
                    Data validate = ValidateName(name, db.Categories);
                    available = validate.Status;
                    Fail(validate.Message);
                } while (!available);
                // do
                // {
                //     do
                //     {
                //         Printer("Enter the category name: ");
                //         name = GetInput();
                //         Data validate = ValidateName(name, db.Categories);
                //     } while (name == null);
                //     available = db.Categories.Any(c => c.CategoryName == name);
                //     if (available)
                //     {
                //         Printer("Category name already exists, please try again.");
                //     }
                // } while (available);

                // Printer("Enter the category name: ");
                // string name = GetInput();

                do
                {
                    Printer("Enter the category Description: ");
                    description = GetInput();
                    Data validate = ValidateDescription(name);
                    available = validate.Status;
                    Fail(validate.Message);
                } while (!available);

                Category category = new Category
                {
                    CategoryName = name,
                    Description = description
                };

				db.Categories?.Add(category);
				db.SaveChanges();

				Info("Category added successfully.");
			}
		}

		static void DeleteCategory()
		{
			using (Northwind db = new())
			{
				SectionTitle("Deleting a Category");

				Printer("Enter the category ID: ");
				string? input = GetInput();
				int id = int.Parse(input);

				Category? category = db.Categories?.Find(id);

				if (category is null)
				{
					Fail("Category not found.");
					return;
				}

				db.Categories?.Remove(category);
				db.SaveChanges();

				Info("Category deleted successfully.");
			}
		}

		static void AddProduct()
		{
			using (Northwind db = new())
			{
				SectionTitle("Adding a Product");

				Printer("Enter the product name: ");
				string name = GetInput();

				Printer("Enter the product price: ");
				string input = GetInput();
				decimal price = decimal.Parse(input);

				Printer("Enter the product stock level: ");
				input = GetInput();
				short stock = short.Parse(input);

				Printer("Enter the category ID: ");
				input = GetInput();
				int categoryId = int.Parse(input);

				Product product = new Product
				{
					ProductName = name,
					Cost = price,
					Stock = stock,
					CategoryId = categoryId
				};

				db.Products?.Add(product);
				db.SaveChanges();

				Info("Product added successfully.");
			}
		}

		static void UpdateProduct()
		{
			using (Northwind db = new())
			{
				SectionTitle("Updating a Product");

				Printer("Enter the product ID: ");
				string input = GetInput();
				int id = int.Parse(input);

				Product? product = db.Products?.Find(id);

				if (product is null)
				{
					Fail("Product not found.");
					return;
				}

				Printer("Enter the new product name (leave empty to keep the existing name): ");
				string name = GetInput();

				if (!string.IsNullOrEmpty(name))
				{
					product.ProductName = name;
				}

				Printer("Enter the new product price (leave empty to keep the existing price): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.Cost = decimal.Parse(input);
				}

				Printer("Enter the new product stock level (leave empty to keep the existing stock level): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.Stock = short.Parse(input);
				}

				Printer("Enter the new category ID (leave empty to keep the existing category): ");
				input = GetInput();

				if (!string.IsNullOrEmpty(input))
				{
					product.CategoryId = int.Parse(input);
				}

				db.SaveChanges();

				Info("Product updated successfully.");
			}
		}

		static void DeleteProduct()
		{
			using (Northwind db = new())
			{
				SectionTitle("Deleting a Product");

				Printer("Enter the product ID: ");
				string input = GetInput();
				int id = int.Parse(input);

				Product? product = db.Products?.Find(id);

				if (product is null)
				{
					Fail("Product not found.");
					return;
				}
				if (product.Category is not null)
				{
					product.Category.Products.Remove(product);
				}
				db.Products?.Remove(product);
				db.SaveChanges();

				Info("Product deleted successfully.");
			}
		}
	}
}
