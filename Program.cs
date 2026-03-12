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
     public void SetName(string n)
    {
        // In a real application, you would validate the name before setting it.
        this.Name = n;
    }
    private float price;
    public float GetPrice()
    { 
        return price;
    }
     public void SetPrice(float p)
    {
        // In a real application, you would validate the price before setting it.
        this.price = p;
    }

    public Product(string name,float price)
    {
        this.Name = name;
        this.price = price;
    }
}

public class Customer
{
    private string firstName;
    public string GetFirstName()
    {
        return firstName;
    }
     public void SetFirstName(string f)
    {
        // In a real application, you would validate the first name before setting it.
        this.firstName = f;
    }

    private string lastName;
    public string GetLastName()
    {
        return lastName;
    }
     public void SetLastName(string l)
    {
        // In a real application, you would validate the last name before setting it.
        this.lastName = l;
    }

    private string Email;
    public string GetEmail()
    {
        return Email;
    }
     public void SetEmail(string e)
    {
        // In a real application, you would validate the email before setting it.
        this.Email = e;
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
    public int OrderNumber { get; set; }
    public double TotalAmount { get; set; }
    public bool IsPaid { get; set; }

    public Order(int orderNumber, double totalAmount, bool isPaid = false)
    {
        OrderNumber = orderNumber;
        TotalAmount = totalAmount;
        IsPaid = isPaid;
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

public class ProductId
{
    private int id;
    private string name;
    private double price;

    public ProductId(int id, string name, double price)
    {
        this.id = id;
        this.name = name;
        this.price = price;
    }

    // Propriété en lecture seule (pas de set)
    public int Id 
    { 
        get { return id; } 
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Price
    {
        get { return price; }
        set { price = value; }
    }
}



class Program
{
    static void Main(string[] args)
    {
        Product p1 = new Product("",0);
        p1.SetName("Laptop");
        p1.SetPrice(1200);
        Console.WriteLine($"\nProduct created: {p1.GetName()} with price: {p1.GetPrice()}");

        Customer c1 = new Customer($"John", $"Doe", $"john.doe@example.com");
        Console.WriteLine($"Customer created: First Name: {c1.GetFirstName()}, Last Name: {c1.GetLastName()}, Email: {c1.GetEmail()}");
        Order o1 = new Order(1001, 350.0, true);
        Console.WriteLine($"Order N°{o1.OrderNumber} | Total: {o1.TotalAmount} | Paid: {o1.IsPaid}");
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

        ProductId myProd = new ProductId(1, "Tablet", 600);
        Console.WriteLine($"ProductId created: ID: {myProd.Id}, Name: {myProd.Name}, Price: {myProd.Price}");
}
}