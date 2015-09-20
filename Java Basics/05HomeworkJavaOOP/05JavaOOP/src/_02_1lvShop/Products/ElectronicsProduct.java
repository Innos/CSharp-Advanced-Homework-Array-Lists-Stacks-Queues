package _02_1lvShop.Products;


import _02_1lvShop.AgeRestriction;

import java.time.Period;

public abstract class ElectronicsProduct extends Product{

    private int guaranteePeriod;

    protected ElectronicsProduct(String name, double price, int quantity, AgeRestriction restriction, int guaranteePeriod) {
        super(name, price, quantity, restriction);

        this.setGuaranteePeriod(guaranteePeriod);
    }

    public int getGuaranteePeriod() {
        return guaranteePeriod;
    }

    private void setGuaranteePeriod(int guaranteePeriod) {
        this.guaranteePeriod = guaranteePeriod;
    }
}
