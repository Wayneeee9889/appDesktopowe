using System.Linq;
using Diagnostyka;
// (Diagnostyka_3K: nazwa projektu w którym są pliki);

Product p = new Product("Laptop", 1500.99f, "Electronics");
Product p2 = new Product("Smartphone", 899.00f, "Electronics");
Product p3 = new Product("Headphones", 199.99f, "Electronics");
Product p4 = new Product("modern fan", 49.99f, "Electronics");
Product p5 = new Product("kettle", 29.99f, "Electronics");
Product p6 = new Product("fridge", 2999.99f, "Electronics");

List<Product> products = new List<Product> ();
products.Add(p);
products.Add(p2);
products.Add(p3);
products.Add(p4);
products.Add(p5);
products.Add(p6);
Console.WriteLine ("Lista produktów:");
foreach (Product product in products)
{
    Console.WriteLine(product.name + " - " + product.price + " - " + product.category);
}
Console.WriteLine("\n\n");


double priceaverange = products.Average(product => product.price);
Console.WriteLine("Produkty tańsze niż średnia cena" + "(" + Math.Round(priceaverange, 2) + ")");
//Console.WriteLine(priceaverange);
for (int i = 0; i < products.Count; i++)
{
    if (priceaverange > products[i].price)
    {
        Console.WriteLine(products[i].name + " - " + products[i].price + " - " + products[i].category);
    }
}
Console.WriteLine("\n\n");

Console.WriteLine("Lista produktów posortowana malejąco według ceny:");
for (int i = 0; i < products.Count; i++)
{
    var sortedProducts = products.OrderByDescending(product => product.price);
    Console.WriteLine(sortedProducts.ElementAt(i).name + " - " + sortedProducts.ElementAt(i).price + " - " + sortedProducts.ElementAt(i).category);
}
