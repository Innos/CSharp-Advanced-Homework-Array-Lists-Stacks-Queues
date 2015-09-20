package _02_1lvShop.Products;

import _02_1lvShop.AgeRestriction;

import java.time.Period;

public class Computer extends ElectronicsProduct{

    public Computer(String name, double price, int quantity, AgeRestriction restriction) {
        super(name, price, quantity, restriction, 24);
    }

    @Override
    public double getPrice() {
        if(this.getQuantity() > 1000){
            return super.getPrice() * 0.95;
        }
        return super.getPrice();
    }
}
