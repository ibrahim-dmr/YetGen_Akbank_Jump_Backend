using System;
using System.Linq;
using System.Collections.Generic;
using EFCore_InMemoryExercises.Entities;
using EFCore_InMemoryExercises.Persistence;

using (var context = new DataDbContext())
{
    // Veri Ekleme
    var categoryId = Guid.NewGuid();
    var category = new Category { Id = categoryId, Name = "Electronics" };
    context.Categories.Add(category);

    var productId = Guid.NewGuid();
    var product = new Product { Id = productId, Name = "Laptop", Price = 1000, CategoryId = categoryId };
    context.Products.Add(product);

    context.SaveChanges();

    // Veri Güncelleme
    var updatedProduct = context.Products.FirstOrDefault(p => p.Name == "Laptop");
    if (updatedProduct != null)
    {
        updatedProduct.Price = 1200;
        context.SaveChanges();
    }

    // Veri Silme
    var productToDelete = context.Products.FirstOrDefault(p => p.Name == "Laptop");
    if (productToDelete != null)
    {
        context.Products.Remove(productToDelete);
        context.SaveChanges();
    }
}