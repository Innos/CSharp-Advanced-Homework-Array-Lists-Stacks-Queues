using System;



class Laptop
{
    //Fields
    private string model;
    private string manufacturer;
    private string processor;
    private int? ram;
    private string graphicsCard;
    private string hdd;
    private string screen;
    private Battery battery = new Battery();
    private decimal price;

    //Properties
    public string Model
    {
        get { return this.model; }
        private set
        {
            if (value == null || value.Trim() == "")
            {
                throw new ArgumentNullException("Model cannot be empty!");
            }
            this.model = value;
        }
    }
    public string Manufacterer
    {
        get { return this.manufacturer; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Manufacturer cannot be empty");
            }
            this.manufacturer = value;
        }
    }
    public string Processor
    {
        get { return this.processor; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Processor cannot be empty");
            }
            this.processor = value;
        }
    }
    public int? RAM
    {
        get { return this.ram; }
        private set
        {
            if (value != null && value < 0)
            {
                throw new ArgumentOutOfRangeException("RAM cannot be negative");
            }
            this.ram = value;
        }
    }
    public string GraphicsCard
    {
        get { return this.graphicsCard; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Graphics Card cannot be empty");
            }
            this.graphicsCard = value;
        }
    }
    public string HDD
    {
        get { return this.hdd; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Hard Disk Drive cannot be empty");
            }
            this.hdd = value;
        }
    }
    public string Screen
    {
        get { return this.screen; }
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Screen cannot be empty");
            }
            this.screen = value;
        }
    }
    public Battery Battery
    {
        get { return this.battery; }
        private set { this.battery = value; }
    }
    public decimal Price
    {
        get { return this.price; }
        set
        {
            this.price = value;
        }
    }

    //Constructors
    public Laptop(string model, decimal price)
        : this(model, null, null, null, null, null, null,new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, decimal price)
        : this(model, manufacturer, null, null, null, null, null, new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, string processor, decimal price)
        : this(model, manufacturer, processor, null, null, null, null, new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, string processor, int? ram, decimal price)
        : this(model, manufacturer, processor, ram, null, null, null, new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, string processor, int? ram, string graphicsCard, decimal price)
        : this(model, manufacturer, processor, ram, graphicsCard, null, null, new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, string processor, int? ram, string graphicsCard, string hdd, decimal price)
        : this(model, manufacturer, processor, ram, graphicsCard, hdd, null, new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, string processor, int? ram, string graphicsCard, string hdd, string screen, decimal price)
        : this(model, manufacturer, processor, ram, graphicsCard, hdd, screen, new Battery(), price)
    {
    }
    public Laptop(string model, string manufacturer, string processor, int? ram, string graphicsCard, string hdd, string screen, Battery battery, decimal price)
    {
        this.Model = model;
        this.Manufacterer = manufacturer;
        this.Processor = processor;
        this.RAM = ram;
        this.GraphicsCard = graphicsCard;
        this.HDD = hdd;
        this.Screen = screen;
        this.battery = battery;
        this.Price = price;
    }

    //Methods
    public override string ToString()
    {
        return String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}{11}",
            new string('=',77),
            String.Format("\n|{0,-14}|{1,-60}|","Model",this.Model),
        this.Manufacterer != null ? String.Format("\n|{0,-14}|{1,-60}|","Manufacturer",this.Manufacterer) : "",
        this.Processor != null ? String.Format("\n|{0,-14}|{1,-60}|","Processor",this.Processor) : "",
        this.RAM != null ? String.Format("\n|{0,-14}|{1,-60}|","RAM",this.RAM + "GB") : "",
        this.GraphicsCard != null ? String.Format("\n|{0,-14}|{1,-60}|","Graphics Card",this.GraphicsCard) : "",
        this.HDD != null ? String.Format("\n|{0,-14}|{1,-60}|","HDD",this.HDD) : "",
        this.Screen != null ? String.Format("\n|{0,-14}|{1,-60}|","Screen",this.Screen) : "",
        this.battery.Name != null ? String.Format("\n|{0,-14}|{1,-60}|","Battery",this.battery.Name) : "",
        this.battery.BatteryLife != null ? String.Format("\n|{0,-14}|{1,-60}|","Battery Life",this.battery.BatteryLife) : "",
        String.Format("\n|{0,-14}|{1,-60}|","Price",this.Price.ToString("0.00") + "lv"),
        String.Format("\n{0}\n",new string('=',77)));
    }
}

