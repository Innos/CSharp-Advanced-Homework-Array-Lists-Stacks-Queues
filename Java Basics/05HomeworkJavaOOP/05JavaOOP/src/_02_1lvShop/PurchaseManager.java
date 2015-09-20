package _02_1lvShop;


import _02_1lvShop.Exceptions.BuyerException;
import _02_1lvShop.Exceptions.ProductException;
import _02_1lvShop.Products.FoodProduct;
import _02_1lvShop.Products.Product;

import java.time.LocalDate;

public class PurchaseManager {

    public static void processPurchase(Product product, Customer customer)
            throws ProductException, BuyerException {
        if (product.getQuantity() <= 0) {
            throw new ProductException("Product is out of stock.");
        }
        if (product instanceof FoodProduct && LocalDate.now().isAfter(((FoodProduct) product).getExpirationDate())) {
            throw new ProductException("Product has expired.");
        }
        if (customer.getBalance() < product.getPrice()) {
            throw new BuyerException("You do not have enough money to buy this product!");
        }
        if (customer.getAge() < product.getRestriction().getValue()) {
            throw new BuyerException("You are too young to buy this product!");
        }

        product.setQuantity(product.getQuantity() - 1);
        customer.setBalance(customer.getBalance() - product.getPrice());
    }
}
