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
    static Product BinarySearch(Product[] products, int id)
    {
        int low = 0;
        int high = products.Length - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (products[mid].ProductId == id)
                return products[mid];
            else if (products[mid].ProductId < id)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return null;
    }

    static void Main()
    {
        // Array must be sorted by ProductId
        Product[] products =
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Phone", "Electronics"),
            new Product(103, "Shoes", "Fashion"),
            new Product(104, "Watch", "Accessories")
        };

        int searchId = 103;

        Product result = BinarySearch(products, searchId);

        if (result != null)
        {
            Console.WriteLine("Product Found");
            Console.WriteLine("Product ID: " + result.ProductId);
            Console.WriteLine("Product Name: " + result.ProductName);
            Console.WriteLine("Category: " + result.Category);
        }
        else
        {
            Console.WriteLine("Product Not Found");
        }
    }
}