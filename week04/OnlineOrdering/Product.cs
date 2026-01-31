public class Product
{
    private string _name;
    private string _productID;
    private decimal _price;
    private int _quantity;

    public Product(string name, string ID, decimal price, int quantity)
    {
        _name = name;
        _productID = ID;
        _price = price;
        _quantity = quantity;
    }

    public string Name
    {
        get { return _name; }
    }

    public string ProductID
    {
        get { return _productID; }
    }
    
    public decimal TotalCost()
    {
        return _price * _quantity;
    }
}