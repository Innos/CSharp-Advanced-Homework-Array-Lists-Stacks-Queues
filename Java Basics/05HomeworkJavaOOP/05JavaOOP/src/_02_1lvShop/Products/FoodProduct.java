package _02_1lvShop.Products;

import _02_1lvShop.AgeRestriction;
import _02_1lvShop.Interfaces.Expirable;

import java.time.LocalDate;

public class FoodProduct extends Product implements Expirable,Comparable<FoodProduct>{

    private LocalDate expirationDate;

    public FoodProduct(String name, double price, int quantity, AgeRestriction restriction, LocalDate expirationDate) {
        super(name, price, quantity, restriction);

        this.setExpirationDate(expirationDate);
    }

    @Override
    public LocalDate getExpirationDate() {
        return expirationDate;
    }

    public void setExpirationDate(LocalDate expirationDate) {
        this.expirationDate = expirationDate;
    }

    @Override
    public double getPrice() {
        LocalDate now = LocalDate.now();
        if(now.plusDays(15).isAfter(this.expirationDate)){
            return super.getPrice() * 0.7;
        }
        return super.getPrice();
    }

    @Override
    public int compareTo(FoodProduct o) {
        if(this.getExpirationDate().isAfter(o.getExpirationDate())){
            return 1;
        }
        else if(this.getExpirationDate().isEqual(o.getExpirationDate())){
            return 0;
        }
        else{
            return -1;
        }
    }

    @Override
    public String toString() {
        StringBuilder result = new StringBuilder(super.toString());
        result.append(String.format("\tExpiration Date: %s\n",this.getExpirationDate()));
        return result.toString();
    }
}
