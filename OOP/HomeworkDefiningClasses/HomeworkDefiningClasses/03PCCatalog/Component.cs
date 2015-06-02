using System;



class Component
{
    //Fields
    private string name;
    private string details;
    private decimal? price;

    //Properties
    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public string Details
    {
        get { return this.details; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentOutOfRangeException("Detail cannot be empty");
            }
            this.details = value;
        }
    }
    public decimal? Price
    {
        get { return this.price; }
        set
        {
            if (value != null && value < 0)
            {
                throw new ArgumentOutOfRangeException("Price cannot be negative");
            }
            this.price = value;
        }
    }

    //Constructors
    public Component() : this(null,null,null)
    {
    }
    public Component(string name, decimal price) : this(name, null, price)
    {
    }
    public Component(string name, string details, decimal? price)
    {
        this.Name = name;
        this.Details = details;
        this.Price = price;
    }
}

