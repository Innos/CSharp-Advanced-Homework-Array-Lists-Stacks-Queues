using System;



class Battery
{
    //Fields
    private string name;
    private double? batteryLife;

    //Properties
    public string Name 
    {
        get{ return this.name;}
        private set
        {
            if (value != null && value.Trim() == "")
            {
                throw new ArgumentNullException("Battery cannot be empty!");
            }
            this.name = value;
        }
    }
    public double? BatteryLife
    {
        get
        {
            return this.batteryLife;
        }
        private set
        {
            if (value != null && value < 0)
            {
                throw new ArgumentOutOfRangeException("Battery Life cannot be negative!");
            }
            this.batteryLife = value;
        }
    }

    //Constructors
    public Battery() : this(null, null)
    {
    }
    public Battery(string name, double? batteryLife)
    {
        this.Name = name;
        this.BatteryLife = batteryLife;
    }

    //Methods
    public override string ToString()
    {
        return String.Format("Battery Name: {0}\nBattery Life:{1}",
            this.Name ?? "N/A",
            this.BatteryLife);
    }
}

