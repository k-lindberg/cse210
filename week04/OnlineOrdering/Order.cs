using System.Collections.Immutable;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }


    public decimal TotalPrice()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.TotalCost();
        }

        total += ShippingCost();
        
        return total;
    }

    public decimal ShippingCost()
    {
        int shipping = 0;

        if (_customer.IsInUSA())
        {
            shipping = 5;
        }

        else
        {
            shipping = 35;
        }
        return shipping;
    }

    public string PackingLabel()
    {
        string label = "";

        foreach (Product packingLabel in _products)
        {
            label += $"{packingLabel.Name} ({packingLabel.ProductID})\n";
        }

        return label;
    }
    
    public string ShippingLabel()
    {
        return _customer.GetDisplayText();
    }
}