using System;

class Product
{
    public int ProductId;
    public string ProductName;
    public string Category;

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
}

class Program
{
    static Product LinearSearch(Product[] products, int id)
    {
        foreach (Product product in products)
        {
            if (product.ProductId == id)
                return product;
        }
        return null;
    }

    static void Main()
    {
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Phone", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Watch", "Accessories")
        };

        int searchId = 103;

        Product result = LinearSearch(products, searchId);

        if (result != null)
            Console.WriteLine("Product Found: " + result.ProductName);
        else
            Console.WriteLine("Product Not Found");
    }
}