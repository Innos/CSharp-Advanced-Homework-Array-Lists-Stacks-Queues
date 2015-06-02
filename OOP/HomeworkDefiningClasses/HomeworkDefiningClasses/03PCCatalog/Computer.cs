using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;



class Computer
{
    //Fields
    private string name;
    private List<Component> components = new List<Component>();

    //Properties
    public decimal Price
    {
        get
        {
            return (decimal)this.components.Sum(component => component.Price);
        }
    }
    public string Name
    {
        get { return this.name; }
        private set 
        { 
            if(String.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            this.name = value;
        }
    }
    public List<Component> Components
    {
        get { return this.components; }
        private set
        {
            if(value.Count == 0)
            {
                throw new ArgumentNullException("Computer must have atleast 1 component");
            }
            this.components = value;
        }
    }
    
    //Constructors
    public Computer(string name, Component component1) : this(name,component1,new Component(),new Component())
    {
    }
    public Computer(string name, Component component1,Component component2) : this(name,component1,component2,new Component())
    {
    }
    public Computer(string name, Component component1, Component component2, Component component3)
    {
        this.Name = name;
        AddComponent(component1);
        AddComponent(component2);
        AddComponent(component3);
    }
    public Computer(string name,List<Component> components)
    {
        this.Name = name;
        this.Components = components;
    }

    //Methods
    public void AddComponent(Component component)
    {
        if(Components.Any(comp=>comp.Name == component.Name))
        {
            throw new ArgumentException("Component already exists!");
        }
        this.Components.Add(component);
    }
    public override string ToString()
    {
        StringBuilder computerToString = new StringBuilder();
        computerToString.AppendLine(new string('=', this.Name.Length+1));
        computerToString.AppendLine(String.Format("{0}:",this.Name));
        computerToString.Append(new string('=', this.Name.Length+1));
        foreach (var component in Components)
        {
            if (component.Name != null)
            {
                computerToString.Append(String.Format("\n{0}:", component.Name));
                computerToString.Append(String.Format("{0}{1}",
                    component.Details != null ? String.Format("\n\tDetails: {0}", component.Details) : "",
                    String.Format("\n\tPrice: {0}", ((decimal)component.Price).ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")))));
            }
        }
        string totalPrice = String.Format("Total Price: {0}", this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG")));
        computerToString.AppendLine();
        computerToString.AppendLine(new string('-', totalPrice.Length));
        computerToString.AppendLine(totalPrice);
        computerToString.AppendLine(new string('=', 70));
        return computerToString.ToString();
    }
}

