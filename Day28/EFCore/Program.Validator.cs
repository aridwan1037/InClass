using EFCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ProgramEFCore
{
    public partial class Program
    {
        public static Data ValidateName(string name, IQueryable<Category> categories)
        {
            if (name.Trim().Length < 3)
                return new Data("Name should be at least 3 characters long!!!", false);
            if (categories.Any(c => c.CategoryName == name))
                return new Data("Name is already in use", false);
            return new Data(name, true);
        }
        public static Data ValidateDescription(string description)
        {
            if (description.Trim().Length < 10)
                return new Data("Description should be at least 10 characters long!!!", false);
            return new Data(description, true);
        }
    }
}