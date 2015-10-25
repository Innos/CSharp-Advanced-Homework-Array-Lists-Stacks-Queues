package _02_1lvShop;

import _02_1lvShop.Products.Appliance;
import _02_1lvShop.Products.Computer;
import _02_1lvShop.Products.FoodProduct;
import _02_1lvShop.Products.Product;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.ArrayList;
import java.util.List;
import java.util.Locale;
import java.util.stream.Collectors;

public class Shop {
    public static void main(String[] args) {
        Locale.setDefault(Locale.ROOT);

        FoodProduct apple = new FoodProduct("Apple", 5.00, 150, AgeRestriction.None, LocalDate.parse("2015-09-25", DateTimeFormatter.ISO_LOCAL_DATE));
        FoodProduct cheese = new FoodProduct("Cheese", 15.00, 1000, AgeRestriction.Adult, LocalDate.parse("2014-12-12", DateTimeFormatter.ISO_LOCAL_DATE));
        Appliance vacuum = new Appliance("Vacuum 2000X", 150.99, 1, AgeRestriction.Adult);
        Appliance drill = new Appliance("Power Drill 666Q", 220.22, 10, AgeRestriction.Adult);
        Computer hp = new Computer("HP 255 G2", 450.88, 10, AgeRestriction.Teenager);
        Computer lenovo = new Computer("Lenovo Tablet A", 758.45, 20, AgeRestriction.None);
        Computer lenovo2 = new Computer("Lenovo Fitness", 1024.24, 5, AgeRestriction.Adult);

        Customer goshko = new Customer("Goshko", 12, 45);
        Customer ivan = new Customer("Ivan Ivanov", 33, 1000);
        Customer pesho = new Customer("Pesho", 16, 1000);

        //pass
        testProcessPurchase(apple, goshko);
        //not enough money
        testProcessPurchase(lenovo, goshko);
        // buys last vacuum changes quantity to 0
        testProcessPurchase(vacuum, ivan);
        //no quantity
        testProcessPurchase(vacuum, ivan);
        //pass
        testProcessPurchase(lenovo, ivan);
        // not enough money
        testProcessPurchase(hp, ivan);
        //expired
        testProcessPurchase(cheese, pesho);
        //age restriction
        testProcessPurchase(drill, pesho);
        //pass
        testProcessPurchase(hp, pesho);

        ArrayList<Product> products = new ArrayList<>();
        products.add(apple);
        products.add(cheese);
        products.add(vacuum);
        products.add(drill);
        products.add(hp);
        products.add(lenovo);
        products.add(lenovo2);

        //filter the food products then cast to food product and find the food products whose expiration date has not passed yet,
        //then sort them (by the implemented sorter in the class, which sorts by date), take the first element and select the name
        String result = products.stream()
                .filter(p -> p instanceof FoodProduct)
                .map(p -> (FoodProduct) p)
                .filter(p -> p.getExpirationDate().isAfter(LocalDate.now()))
                .sorted()
                .findFirst()
                .map(p -> p.getName())
                .get();

        List<Product> result2 = products.stream()
                .filter(p -> p.getRestriction() == AgeRestriction.Adult)
                .sorted((p1, p2) -> Double.compare(p1.getPrice(), p2.getPrice()))
                .collect(Collectors.toList());

        System.out.println("Search #1:");
        System.out.println(result);
        System.out.println();
        System.out.println("Search #2:");
        System.out.println(result2);

    }

    private static void testProcessPurchase(Product product, Customer customer) {
        try {
            PurchaseManager.processPurchase(product, customer);
        } catch (Exception ex) {
            System.out.println(ex.getMessage());
        }
    }
}
