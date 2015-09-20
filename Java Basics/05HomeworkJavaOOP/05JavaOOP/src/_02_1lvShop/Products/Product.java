package _02_1lvShop.Products;

import _02_1lvShop.AgeRestriction;
import _02_1lvShop.Interfaces.Buyable;

public abstract class Product implements Buyable{

    private String name;
    private double price;
    private int quantity;
    private AgeRestriction restriction;

    protected Product(String name, double price, int quantity, AgeRestriction restriction){
        this.setName(name);
        this.setPrice(price);
        this.setQuantity(quantity);
        this.setRestriction(restriction);
    }

    public String getName() {
        return name;
    }

    private void setName(String name) {
        if(name == null || name.trim().equals("")){
            throw new IllegalArgumentException("Name cannot be empty.");
        }
        this.name = name;
    }

    public double getPrice(){
        return this.price;
    }

    private void setPrice(double price) {
        if(price < 0){
            throw new IllegalArgumentException("Price cannot be negative.");
        }
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        if(quantity < 0){
            throw new IllegalArgumentException("Quantity cannot be negative.");
        }
        this.quantity = quantity;
    }

    public AgeRestriction getRestriction() {
        return restriction;
    }

    private void setRestriction(AgeRestriction restriction) {
        this.restriction = restriction;
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder();
        result.append(this.getName() + "\n");
        result.append(String.format("\tPrice: %.2f\n", this.getPrice()));
        result.append(String.format("\tQuantity: %d\n",this.getQuantity()));
        result.append(String.format("\tAge Restriction: %s\n",this.getRestriction()));
        return result.toString();
    }
}
