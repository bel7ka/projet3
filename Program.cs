using System.Collections;
using System.Runtime.CompilerServices;

namespace projet_3;
//projet_shop


public class Product
{
    private string Name;
    public string GetName()
    {
        return Name;
    }
    private float price;
    public float GetPrice()
    { 
        return price;
    }

    public Product(string name,float price)
    {
        this.Name = name;
        this.price = price;
    }
}

public class Customer
{
    private string firstName { get; set; }
    public string GetFirstName()
    {
        return firstName;
    }

    private string lastName { get; set; } 
    public string GetLastName()
    {
        return lastName;
    }

    private string Email { get; set; }
    public string GetEmail()
    {
        return Email;
    }
    public Customer(string firstName, string lastName, string email)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.Email = email;
    }
}

public class Order
{
    private int orderNumber { get; set; }
    public int GetOrderNumber()
    {
        // In a real application, you would generate a unique order number.
        return orderNumber;
    }

    private double totalAmount { get; set; }
    public double GetTotalAmount()
    {
        // In a real application, you would calculate the total amount based on the items in the order.
        return totalAmount;
    }
    private bool isPaid { get; set; }
    public bool GetIsPaid()
    {
        // In a real application, you would check the payment status of the order.
        return isPaid;
    }

    public Order(int orderNumber, double totalAmount, bool isPaid = false)
    {
        this.orderNumber = orderNumber;
        this.totalAmount = totalAmount;
        this.isPaid = isPaid;
    }

}

public class Item
{
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Item(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
}

public class Supplier
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string city;
    public string City
    {
        get { return city; }
        set { city = value; }
    }
    private string phone;
    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    public Supplier(string name, string city, string phone)
    {
        this.name = name;
        this.city = city;
        this.phone = phone;
    }

}

public class Category
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string description;
    public string Description
    {
        get { return description; }
        set { description = value; }
    }
    public Category(string name, string description)
    {
        this.name = name;
        this.description = description;
    }
}

class ProductId
{
    public int id { get; }
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    public ProductId(int id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }
}



class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("Laptop", 1200);
        Console.WriteLine($"\nProduct created: {p1.GetName()} with price: {p1.GetPrice()}");

        Customer c1 = new Customer($"John", $"Doe", $"john.doe@example.com");
        Console.WriteLine($"Customer created: First Name: {c1.GetFirstName()}, Last Name: {c1.GetLastName()}, Email: {c1.GetEmail()}");
    
        Order o1 = new Order(1001,350,true);
        Console.WriteLine($"Order created: Order Number: {o1.GetOrderNumber()}, Total Amount: {o1.GetTotalAmount()}, Is Paid: {o1.GetIsPaid()}\n");
        
        Item i1 = new Item("Smartphone", 800, 25);
        Console.WriteLine($"Item created: Name: {i1.Name}, Price: {i1.Price}, Quantity: {i1.Quantity}");
        Supplier s1 = new Supplier("TechSupply", "Paris", "01 02 03 04 05");    
        Console.WriteLine($"Supplier created: Name: {s1.Name}, City: {s1.City}, Phone: {s1.Phone}");
        
        Category cat1 = new Category("Electronics", "Electronic devices");
        Console.WriteLine($"Category created: Name: {cat1.Name}, Description: {cat1.Description}");
        Category cat2 = new Category("Books", "Books and literature");
        Console.WriteLine($"Category created: Name: {cat2.Name}, Description: {cat2.Description}");
        Category cat3 = new Category("Clothing", "Clothes and accessories");
        Console.WriteLine($"Category created: Name: {cat3.Name}, Description: {cat3.Description}");
        ProductId pid1 = new ProductId(1, "Tablet", 600);
        Console.WriteLine($"ProductId created: ID: {pid1.id}, Name: {pid1.Name}, Price: {pid1.Price}");
}
}