using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.products = new List<Product>();
        this.customer = customer;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public double GetTotalCost()
    {
        double totalCost = 0;
        foreach (var product in products)
        {
            totalCost += product.GetTotalCost();
        }
        double shippingCost = customer.IsInUSA() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        StringBuilder packingLabel = new StringBuilder();
        foreach (var product in products)
        {
            packingLabel.AppendLine(product.GetPackingInfo());
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"Name: {customer.GetName()}\nAddress:\n{customer.GetAddress()}";
    }
}
