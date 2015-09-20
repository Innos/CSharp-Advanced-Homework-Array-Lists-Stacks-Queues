package _02_1lvShop.Products;

import _02_1lvShop.AgeRestriction;

import java.time.Period;

public class Appliance extends ElectronicsProduct {

    public Appliance(String name, double price, int quantity, AgeRestriction restriction) {
        super(name, price, quantity, restriction, 6);
    }

    @Override
    public double getPrice() {
        if(this.getQuantity() < 50){
            return super.getPrice() * 1.05;
        }
        return super.getPrice();
    }
}
