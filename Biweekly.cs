
// This class stores customer details like ID, name, and email.
public void DisplayInfo()
{
    Console.WriteLine($"Customer ID: {Id}, Name: {Name}, Email: {Email}");
}
using System;

class Customer
{
    // Properties of the Customer class
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    // Constructor to initialize the properties
    public Customer(int id, string name, string email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}
